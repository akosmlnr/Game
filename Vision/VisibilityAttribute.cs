using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x0200017F RID: 383
	[System.Serializable]
	public class VisibilityAttribute : Il2CppSystem.Object
	{
		// Token: 0x06001E48 RID: 7752 RVA: 0x000D187C File Offset: 0x000CFA7C
		// Note: this type is marked as 'beforefieldinit'.
		static VisibilityAttribute()
		{
			Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisibilityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr);
			VisibilityAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, "name");
			VisibilityAttribute.NativeFieldInfoPtr_pointsChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, "pointsChange");
			VisibilityAttribute.NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, "multiplier");
			VisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, 100666770);
			VisibilityAttribute.NativeMethodInfoPtr_Delete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, 100666771);
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x000D1910 File Offset: 0x000CFB10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 109993, RefRangeEnd = 109997, XrefRangeStart = 109979, XrefRangeEnd = 109993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibilityAttribute(string _name, float _pointsChange, float _multiplier = 1f, int attributeIndex = -1) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _pointsChange;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _multiplier;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref attributeIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x000D1988 File Offset: 0x000CFB88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110005, RefRangeEnd = 110007, XrefRangeStart = 109997, XrefRangeEnd = 110005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityAttribute.NativeMethodInfoPtr_Delete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00010FC0 File Offset: 0x0000F1C0
		public VisibilityAttribute(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x000D19BC File Offset: 0x000CFBBC
		// (set) Token: 0x06001E4D RID: 7757 RVA: 0x00010FC9 File Offset: 0x0000F1C9
		public unsafe string name
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x000D19E4 File Offset: 0x000CFBE4
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x00010FE8 File Offset: 0x0000F1E8
		public unsafe float pointsChange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_pointsChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_pointsChange)) = value;
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x000D1A0C File Offset: 0x000CFC0C
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x00011003 File Offset: 0x0000F203
		public unsafe float multiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_multiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_multiplier)) = value;
			}
		}

		// Token: 0x04001423 RID: 5155
		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001424 RID: 5156
		private static readonly System.IntPtr NativeFieldInfoPtr_pointsChange;

		// Token: 0x04001425 RID: 5157
		private static readonly System.IntPtr NativeFieldInfoPtr_multiplier;

		// Token: 0x04001426 RID: 5158
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Int32_0;

		// Token: 0x04001427 RID: 5159
		private static readonly System.IntPtr NativeMethodInfoPtr_Delete_Public_Void_0;
	}
}
