using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005C2 RID: 1474
	[System.Serializable]
	public class MethAppearanceSettings : Il2CppSystem.Object
	{
		// Token: 0x06008013 RID: 32787 RVA: 0x0022692C File Offset: 0x00224B2C
		// Note: this type is marked as 'beforefieldinit'.
		static MethAppearanceSettings()
		{
			Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MethAppearanceSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr);
			MethAppearanceSettings.NativeFieldInfoPtr_MainColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr, "MainColor");
			MethAppearanceSettings.NativeFieldInfoPtr_SecondaryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr, "SecondaryColor");
			MethAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr, 100679410);
			MethAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr, 100679411);
			MethAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr, 100679412);
		}

		// Token: 0x06008014 RID: 32788 RVA: 0x002269C0 File Offset: 0x00224BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethAppearanceSettings(Color32 mainColor, Color32 secondaryColor) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mainColor;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref secondaryColor;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008015 RID: 32789 RVA: 0x00226A18 File Offset: 0x00224C18
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethAppearanceSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethAppearanceSettings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008016 RID: 32790 RVA: 0x00226A54 File Offset: 0x00224C54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 242027, RefRangeEnd = 242029, XrefRangeStart = 242027, XrefRangeEnd = 242029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUnintialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MethAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008017 RID: 32791 RVA: 0x0003C9A3 File Offset: 0x0003ABA3
		public MethAppearanceSettings(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700268A RID: 9866
		// (get) Token: 0x06008018 RID: 32792 RVA: 0x00226A90 File Offset: 0x00224C90
		// (set) Token: 0x06008019 RID: 32793 RVA: 0x0003C9AC File Offset: 0x0003ABAC
		public unsafe Color32 MainColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MethAppearanceSettings.NativeFieldInfoPtr_MainColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MethAppearanceSettings.NativeFieldInfoPtr_MainColor)) = value;
			}
		}

		// Token: 0x1700268B RID: 9867
		// (get) Token: 0x0600801A RID: 32794 RVA: 0x00226AB8 File Offset: 0x00224CB8
		// (set) Token: 0x0600801B RID: 32795 RVA: 0x0003C9C7 File Offset: 0x0003ABC7
		public unsafe Color32 SecondaryColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MethAppearanceSettings.NativeFieldInfoPtr_SecondaryColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MethAppearanceSettings.NativeFieldInfoPtr_SecondaryColor)) = value;
			}
		}

		// Token: 0x04005734 RID: 22324
		private static readonly System.IntPtr NativeFieldInfoPtr_MainColor;

		// Token: 0x04005735 RID: 22325
		private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryColor;

		// Token: 0x04005736 RID: 22326
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_0;

		// Token: 0x04005737 RID: 22327
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005738 RID: 22328
		private static readonly System.IntPtr NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0;
	}
}
