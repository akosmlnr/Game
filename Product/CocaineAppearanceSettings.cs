using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005B9 RID: 1465
	[System.Serializable]
	public class CocaineAppearanceSettings : Il2CppSystem.Object
	{
		// Token: 0x06007FDF RID: 32735 RVA: 0x00225CF0 File Offset: 0x00223EF0
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineAppearanceSettings()
		{
			Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "CocaineAppearanceSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr);
			CocaineAppearanceSettings.NativeFieldInfoPtr_MainColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, "MainColor");
			CocaineAppearanceSettings.NativeFieldInfoPtr_SecondaryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, "SecondaryColor");
			CocaineAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, 100679381);
			CocaineAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, 100679382);
			CocaineAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr, 100679383);
		}

		// Token: 0x06007FE0 RID: 32736 RVA: 0x00225D84 File Offset: 0x00223F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242026, XrefRangeEnd = 242027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineAppearanceSettings(Color32 mainColor, Color32 secondaryColor) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mainColor;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref secondaryColor;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FE1 RID: 32737 RVA: 0x00225DDC File Offset: 0x00223FDC
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineAppearanceSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineAppearanceSettings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007FE2 RID: 32738 RVA: 0x00225E18 File Offset: 0x00224018
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 242027, RefRangeEnd = 242029, XrefRangeStart = 242027, XrefRangeEnd = 242027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUnintialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CocaineAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007FE3 RID: 32739 RVA: 0x0003C8BA File Offset: 0x0003AABA
		public CocaineAppearanceSettings(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002683 RID: 9859
		// (get) Token: 0x06007FE4 RID: 32740 RVA: 0x00225E54 File Offset: 0x00224054
		// (set) Token: 0x06007FE5 RID: 32741 RVA: 0x0003C8C3 File Offset: 0x0003AAC3
		public unsafe Color32 MainColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineAppearanceSettings.NativeFieldInfoPtr_MainColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineAppearanceSettings.NativeFieldInfoPtr_MainColor)) = value;
			}
		}

		// Token: 0x17002684 RID: 9860
		// (get) Token: 0x06007FE6 RID: 32742 RVA: 0x00225E7C File Offset: 0x0022407C
		// (set) Token: 0x06007FE7 RID: 32743 RVA: 0x0003C8DE File Offset: 0x0003AADE
		public unsafe Color32 SecondaryColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineAppearanceSettings.NativeFieldInfoPtr_SecondaryColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineAppearanceSettings.NativeFieldInfoPtr_SecondaryColor)) = value;
			}
		}

		// Token: 0x040056FB RID: 22267
		private static readonly System.IntPtr NativeFieldInfoPtr_MainColor;

		// Token: 0x040056FC RID: 22268
		private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryColor;

		// Token: 0x040056FD RID: 22269
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0;

		// Token: 0x040056FE RID: 22270
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040056FF RID: 22271
		private static readonly System.IntPtr NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0;
	}
}
