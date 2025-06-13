using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005FC RID: 1532
	public class ItemFilter_ID : ItemFilter
	{
		// Token: 0x0600856E RID: 34158 RVA: 0x00239AA0 File Offset: 0x00237CA0
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_ID()
		{
			Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_ID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr);
			ItemFilter_ID.NativeFieldInfoPtr_IsWhitelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr, "IsWhitelist");
			ItemFilter_ID.NativeFieldInfoPtr_IDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr, "IDs");
			ItemFilter_ID.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr, 100680085);
			ItemFilter_ID.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr, 100680086);
		}

		// Token: 0x0600856F RID: 34159 RVA: 0x00239B20 File Offset: 0x00237D20
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250894, RefRangeEnd = 250899, XrefRangeStart = 250885, XrefRangeEnd = 250894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_ID(List<string> ids) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_ID.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008570 RID: 34160 RVA: 0x00239B6C File Offset: 0x00237D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250899, XrefRangeEnd = 250902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_ID.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008571 RID: 34161 RVA: 0x0003F21B File Offset: 0x0003D41B
		public ItemFilter_ID(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002829 RID: 10281
		// (get) Token: 0x06008572 RID: 34162 RVA: 0x00239BC4 File Offset: 0x00237DC4
		// (set) Token: 0x06008573 RID: 34163 RVA: 0x0003F224 File Offset: 0x0003D424
		public unsafe bool IsWhitelist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ID.NativeFieldInfoPtr_IsWhitelist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ID.NativeFieldInfoPtr_IsWhitelist)) = value;
			}
		}

		// Token: 0x1700282A RID: 10282
		// (get) Token: 0x06008574 RID: 34164 RVA: 0x00239BEC File Offset: 0x00237DEC
		// (set) Token: 0x06008575 RID: 34165 RVA: 0x0003F23F File Offset: 0x0003D43F
		public unsafe List<string> IDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ID.NativeFieldInfoPtr_IDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ID.NativeFieldInfoPtr_IDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005ADA RID: 23258
		private static readonly IntPtr NativeFieldInfoPtr_IsWhitelist;

		// Token: 0x04005ADB RID: 23259
		private static readonly IntPtr NativeFieldInfoPtr_IDs;

		// Token: 0x04005ADC RID: 23260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0;

		// Token: 0x04005ADD RID: 23261
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
