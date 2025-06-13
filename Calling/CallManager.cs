using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;

namespace Il2CppScheduleOne.Calling
{
	// Token: 0x020004CF RID: 1231
	public class CallManager : Singleton<CallManager>
	{
		// Token: 0x06006B7F RID: 27519 RVA: 0x001E31F0 File Offset: 0x001E13F0
		// Note: this type is marked as 'beforefieldinit'.
		static CallManager()
		{
			Il2CppClassPointerStore<CallManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Calling", "CallManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallManager>.NativeClassPtr);
			CallManager.NativeFieldInfoPtr__QueuedCallData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallManager>.NativeClassPtr, "<QueuedCallData>k__BackingField");
			CallManager.NativeMethodInfoPtr_get_QueuedCallData_Public_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100677044);
			CallManager.NativeMethodInfoPtr_set_QueuedCallData_Private_set_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100677045);
			CallManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100677046);
			CallManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100677047);
			CallManager.NativeMethodInfoPtr_QueueCall_Public_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100677048);
			CallManager.NativeMethodInfoPtr_ClearQueuedCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100677049);
			CallManager.NativeMethodInfoPtr_CallCompleted_Private_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100677050);
			CallManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100677051);
		}

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x06006B80 RID: 27520 RVA: 0x001E32D4 File Offset: 0x001E14D4
		// (set) Token: 0x06006B81 RID: 27521 RVA: 0x001E3314 File Offset: 0x001E1514
		public unsafe PhoneCallData QueuedCallData
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_get_QueuedCallData_Public_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_set_QueuedCallData_Private_set_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006B82 RID: 27522 RVA: 0x001E3358 File Offset: 0x001E1558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217116, XrefRangeEnd = 217152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B83 RID: 27523 RVA: 0x001E3394 File Offset: 0x001E1594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217152, XrefRangeEnd = 217179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B84 RID: 27524 RVA: 0x001E33D0 File Offset: 0x001E15D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueCall(PhoneCallData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_QueueCall_Public_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B85 RID: 27525 RVA: 0x001E3414 File Offset: 0x001E1614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217180, RefRangeEnd = 217181, XrefRangeStart = 217179, XrefRangeEnd = 217180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearQueuedCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_ClearQueuedCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B86 RID: 27526 RVA: 0x001E3448 File Offset: 0x001E1648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217181, XrefRangeEnd = 217186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallCompleted(PhoneCallData call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_CallCompleted_Private_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B87 RID: 27527 RVA: 0x001E348C File Offset: 0x001E168C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217186, XrefRangeEnd = 217189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallManager>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B88 RID: 27528 RVA: 0x00032934 File Offset: 0x00030B34
		public CallManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x06006B89 RID: 27529 RVA: 0x001E34C8 File Offset: 0x001E16C8
		// (set) Token: 0x06006B8A RID: 27530 RVA: 0x0003293D File Offset: 0x00030B3D
		public unsafe PhoneCallData _QueuedCallData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallManager.NativeFieldInfoPtr__QueuedCallData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallManager.NativeFieldInfoPtr__QueuedCallData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049A7 RID: 18855
		private static readonly IntPtr NativeFieldInfoPtr__QueuedCallData_k__BackingField;

		// Token: 0x040049A8 RID: 18856
		private static readonly IntPtr NativeMethodInfoPtr_get_QueuedCallData_Public_get_PhoneCallData_0;

		// Token: 0x040049A9 RID: 18857
		private static readonly IntPtr NativeMethodInfoPtr_set_QueuedCallData_Private_set_Void_PhoneCallData_0;

		// Token: 0x040049AA RID: 18858
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040049AB RID: 18859
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040049AC RID: 18860
		private static readonly IntPtr NativeMethodInfoPtr_QueueCall_Public_Void_PhoneCallData_0;

		// Token: 0x040049AD RID: 18861
		private static readonly IntPtr NativeMethodInfoPtr_ClearQueuedCall_Public_Void_0;

		// Token: 0x040049AE RID: 18862
		private static readonly IntPtr NativeMethodInfoPtr_CallCompleted_Private_Void_PhoneCallData_0;

		// Token: 0x040049AF RID: 18863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
