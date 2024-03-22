namespace Blazorium.Common;

public enum ColorVariant
{
    Primary,
    Secondary,
    Success,
    Danger,
    Warning,
    Info,
}

public static class ColorExtensions
{
    public static string Text(this ColorVariant color) => color switch
    {
        ColorVariant.Primary => "text-sky-600 dark:text-sky-300",
        ColorVariant.Secondary => "text-purple-600 dark:text-purple-300",
        ColorVariant.Success => "text-green-600 dark:text-green-300",
        ColorVariant.Danger => "text-red-600 dark:text-red-300",
        ColorVariant.Warning => "text-yellow-600 dark:text-yellow-300",
        ColorVariant.Info => "text-cyan-600 dark:text-cyan-300",
        _ => throw new ArgumentOutOfRangeException(nameof(color), color, null)
    };
}