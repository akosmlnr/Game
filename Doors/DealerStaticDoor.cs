using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000442 RID: 1090
	public class DealerStaticDoor : StaticDoor
	{
		// Token: 0x06005EE2 RID: 24290 RVA: 0x001B8188 File Offset: 0x001B6388
		// Note: this type is marked as 'beforefieldinit'.
		static DealerStaticDoor()
		{
			Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "DealerStaticDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr);
			DealerStaticDoor.NativeFieldInfoPtr_Dealer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr, "Dealer");
			DealerStaticDoor.NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr, 100675483);
			DealerStaticDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr, 100675484);
		}

		// Token: 0x06005EE3 RID: 24291 RVA: 0x001B81F4 File Offset: 0x001B63F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200079, XrefRangeEnd = 200093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsKnockValid(out string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerStaticDoor.NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			message = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005EE4 RID: 24292 RVA: 0x001B8258 File Offset: 0x001B6458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200093, XrefRangeEnd = 200094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerStaticDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerStaticDoor>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerStaticDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005EE5 RID: 24293 RVA: 0x0002C7EB File Offset: 0x0002A9EB
		public DealerStaticDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x06005EE6 RID: 24294 RVA: 0x001B8294 File Offset: 0x001B6494
		// (set) Token: 0x06005EE7 RID: 24295 RVA: 0x0002C7F4 File Offset: 0x0002A9F4
		public unsafe Dealer Dealer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerStaticDoor.NativeFieldInfoPtr_Dealer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerStaticDoor.NativeFieldInfoPtr_Dealer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040040EB RID: 16619
		private static readonly IntPtr NativeFieldInfoPtr_Dealer;

		// Token: 0x040040EC RID: 16620
		private static readonly IntPtr NativeMethodInfoPtr_IsKnockValid_Protected_Virtual_Boolean_byref_String_0;

		// Token: 0x040040ED RID: 16621
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
