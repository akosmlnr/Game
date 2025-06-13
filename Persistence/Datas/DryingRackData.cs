using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B2 RID: 690
	public class DryingRackData : GridItemData
	{
		// Token: 0x060031E5 RID: 12773 RVA: 0x001128A8 File Offset: 0x00110AA8
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackData()
		{
			Il2CppClassPointerStore<DryingRackData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DryingRackData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr);
			DryingRackData.NativeFieldInfoPtr_Input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr, "Input");
			DryingRackData.NativeFieldInfoPtr_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr, "Output");
			DryingRackData.NativeFieldInfoPtr_DryingOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr, "DryingOperations");
			DryingRackData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_Il2CppReferenceArray_1_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr, 100669056);
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x00112928 File Offset: 0x00110B28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136936, RefRangeEnd = 136937, XrefRangeStart = 136926, XrefRangeEnd = 136936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackData(Il2CppSystem.Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet input, ItemSet output, Il2CppReferenceArray<DryingOperation> dryingOperations) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)9) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dryingOperations);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_Il2CppReferenceArray_1_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x0001A4F2 File Offset: 0x000186F2
		public DryingRackData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x060031E8 RID: 12776 RVA: 0x001129F8 File Offset: 0x00110BF8
		// (set) Token: 0x060031E9 RID: 12777 RVA: 0x0001A4FB File Offset: 0x000186FB
		public unsafe ItemSet Input
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_Input);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_Input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x060031EA RID: 12778 RVA: 0x00112A28 File Offset: 0x00110C28
		// (set) Token: 0x060031EB RID: 12779 RVA: 0x0001A51A File Offset: 0x0001871A
		public unsafe ItemSet Output
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_Output);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_Output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x060031EC RID: 12780 RVA: 0x00112A58 File Offset: 0x00110C58
		// (set) Token: 0x060031ED RID: 12781 RVA: 0x0001A539 File Offset: 0x00018739
		public unsafe Il2CppReferenceArray<DryingOperation> DryingOperations
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_DryingOperations);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DryingOperation>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_DryingOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020A3 RID: 8355
		private static readonly System.IntPtr NativeFieldInfoPtr_Input;

		// Token: 0x040020A4 RID: 8356
		private static readonly System.IntPtr NativeFieldInfoPtr_Output;

		// Token: 0x040020A5 RID: 8357
		private static readonly System.IntPtr NativeFieldInfoPtr_DryingOperations;

		// Token: 0x040020A6 RID: 8358
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_Il2CppReferenceArray_1_DryingOperation_0;
	}
}
