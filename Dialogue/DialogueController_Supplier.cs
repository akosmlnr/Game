using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000457 RID: 1111
	public class DialogueController_Supplier : DialogueController
	{
		// Token: 0x06006080 RID: 24704 RVA: 0x001BDCD0 File Offset: 0x001BBED0
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Supplier()
		{
			Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Supplier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr);
			DialogueController_Supplier.NativeFieldInfoPtr__Supplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr, "<Supplier>k__BackingField");
			DialogueController_Supplier.NativeMethodInfoPtr_get_Supplier_Public_get_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr, 100675690);
			DialogueController_Supplier.NativeMethodInfoPtr_set_Supplier_Private_set_Void_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr, 100675691);
			DialogueController_Supplier.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr, 100675692);
			DialogueController_Supplier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr, 100675693);
		}

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x06006081 RID: 24705 RVA: 0x001BDD64 File Offset: 0x001BBF64
		// (set) Token: 0x06006082 RID: 24706 RVA: 0x001BDDA4 File Offset: 0x001BBFA4
		public unsafe Supplier Supplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Supplier.NativeMethodInfoPtr_get_Supplier_Public_get_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Supplier.NativeMethodInfoPtr_set_Supplier_Private_set_Void_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006083 RID: 24707 RVA: 0x001BDDE8 File Offset: 0x001BBFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201937, XrefRangeEnd = 201941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Supplier.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006084 RID: 24708 RVA: 0x001BDE24 File Offset: 0x001BC024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201941, XrefRangeEnd = 201945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Supplier() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Supplier>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Supplier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x0002D454 File Offset: 0x0002B654
		public DialogueController_Supplier(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x06006086 RID: 24710 RVA: 0x001BDE60 File Offset: 0x001BC060
		// (set) Token: 0x06006087 RID: 24711 RVA: 0x0002D45D File Offset: 0x0002B65D
		public unsafe Supplier _Supplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Supplier.NativeFieldInfoPtr__Supplier_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Supplier.NativeFieldInfoPtr__Supplier_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004202 RID: 16898
		private static readonly IntPtr NativeFieldInfoPtr__Supplier_k__BackingField;

		// Token: 0x04004203 RID: 16899
		private static readonly IntPtr NativeMethodInfoPtr_get_Supplier_Public_get_Supplier_0;

		// Token: 0x04004204 RID: 16900
		private static readonly IntPtr NativeMethodInfoPtr_set_Supplier_Private_set_Void_Supplier_0;

		// Token: 0x04004205 RID: 16901
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004206 RID: 16902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
