using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005F7 RID: 1527
	public class IDs : ItemFilter
	{
		// Token: 0x06008551 RID: 34129 RVA: 0x00239428 File Offset: 0x00237628
		// Note: this type is marked as 'beforefieldinit'.
		static IDs()
		{
			Il2CppClassPointerStore<IDs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "IDs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IDs>.NativeClassPtr);
			IDs.NativeFieldInfoPtr_AcceptedIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IDs>.NativeClassPtr, "AcceptedIDs");
			IDs.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDs>.NativeClassPtr, 100680072);
			IDs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDs>.NativeClassPtr, 100680073);
		}

		// Token: 0x06008552 RID: 34130 RVA: 0x00239494 File Offset: 0x00237694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250814, XrefRangeEnd = 250817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDs.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008553 RID: 34131 RVA: 0x002394EC File Offset: 0x002376EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250817, XrefRangeEnd = 250825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDs() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IDs>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IDs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008554 RID: 34132 RVA: 0x0003F195 File Offset: 0x0003D395
		public IDs(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002825 RID: 10277
		// (get) Token: 0x06008555 RID: 34133 RVA: 0x00239528 File Offset: 0x00237728
		// (set) Token: 0x06008556 RID: 34134 RVA: 0x0003F19E File Offset: 0x0003D39E
		public unsafe List<string> AcceptedIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IDs.NativeFieldInfoPtr_AcceptedIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IDs.NativeFieldInfoPtr_AcceptedIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005ACA RID: 23242
		private static readonly IntPtr NativeFieldInfoPtr_AcceptedIDs;

		// Token: 0x04005ACB RID: 23243
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;

		// Token: 0x04005ACC RID: 23244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
