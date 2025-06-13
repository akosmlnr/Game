using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002BB RID: 699
	[System.Serializable]
	public class ProceduralGridItemData : BuildableItemData
	{
		// Token: 0x06003238 RID: 12856 RVA: 0x0011392C File Offset: 0x00111B2C
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralGridItemData()
		{
			Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ProceduralGridItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr);
			ProceduralGridItemData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr, "Rotation");
			ProceduralGridItemData.NativeFieldInfoPtr_FootprintMatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr, "FootprintMatches");
			ProceduralGridItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Int32_Il2CppReferenceArray_1_FootprintMatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr, 100669065);
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x00113998 File Offset: 0x00111B98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136992, RefRangeEnd = 136993, XrefRangeStart = 136987, XrefRangeEnd = 136992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralGridItemData(Il2CppSystem.Guid guid, ItemInstance item, int loadOrder, int rotation, Il2CppReferenceArray<FootprintMatchData> footprintMatches) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItemData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(footprintMatches);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Int32_Il2CppReferenceArray_1_FootprintMatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600323A RID: 12858 RVA: 0x0001A883 File Offset: 0x00018A83
		public ProceduralGridItemData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x0600323B RID: 12859 RVA: 0x00113A20 File Offset: 0x00111C20
		// (set) Token: 0x0600323C RID: 12860 RVA: 0x0001A88C File Offset: 0x00018A8C
		public unsafe int Rotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItemData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItemData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x0600323D RID: 12861 RVA: 0x00113A48 File Offset: 0x00111C48
		// (set) Token: 0x0600323E RID: 12862 RVA: 0x0001A8A7 File Offset: 0x00018AA7
		public unsafe Il2CppReferenceArray<FootprintMatchData> FootprintMatches
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItemData.NativeFieldInfoPtr_FootprintMatches);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FootprintMatchData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItemData.NativeFieldInfoPtr_FootprintMatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020C8 RID: 8392
		private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x040020C9 RID: 8393
		private static readonly System.IntPtr NativeFieldInfoPtr_FootprintMatches;

		// Token: 0x040020CA RID: 8394
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Int32_Il2CppReferenceArray_1_FootprintMatchData_0;
	}
}
