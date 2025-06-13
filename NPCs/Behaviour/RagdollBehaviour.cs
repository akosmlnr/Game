using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000381 RID: 897
	public class RagdollBehaviour : Behaviour
	{
		// Token: 0x06004498 RID: 17560 RVA: 0x001564B0 File Offset: 0x001546B0
		// Note: this type is marked as 'beforefieldinit'.
		static RagdollBehaviour()
		{
			Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "RagdollBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr);
			RagdollBehaviour.NativeFieldInfoPtr_Seizure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, "Seizure");
			RagdollBehaviour.NativeFieldInfoPtr_SeizureForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, "SeizureForce");
			RagdollBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.RagdollBehaviourAssembly-CSharp.dll_Excuted");
			RagdollBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.RagdollBehaviourAssembly-CSharp.dll_Excuted");
			RagdollBehaviour.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, 100671748);
			RagdollBehaviour.NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, 100671749);
			RagdollBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, 100671750);
			RagdollBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, 100671751);
			RagdollBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, 100671752);
			RagdollBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, 100671753);
			RagdollBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr, 100671754);
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x001565BC File Offset: 0x001547BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158468, XrefRangeEnd = 158471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RagdollBehaviour.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x001565F0 File Offset: 0x001547F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158471, XrefRangeEnd = 158475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InfrequentUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RagdollBehaviour.NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x00156624 File Offset: 0x00154824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158475, XrefRangeEnd = 158476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RagdollBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollBehaviour>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RagdollBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x00156660 File Offset: 0x00154860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158476, XrefRangeEnd = 158477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RagdollBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x0015669C File Offset: 0x0015489C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RagdollBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x001566D8 File Offset: 0x001548D8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RagdollBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x00156714 File Offset: 0x00154914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RagdollBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x000216E9 File Offset: 0x0001F8E9
		public RagdollBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x060044A1 RID: 17569 RVA: 0x00156750 File Offset: 0x00154950
		// (set) Token: 0x060044A2 RID: 17570 RVA: 0x000216F2 File Offset: 0x0001F8F2
		public unsafe bool Seizure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RagdollBehaviour.NativeFieldInfoPtr_Seizure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RagdollBehaviour.NativeFieldInfoPtr_Seizure)) = value;
			}
		}

		// Token: 0x170014A3 RID: 5283
		// (get) Token: 0x060044A3 RID: 17571 RVA: 0x00156778 File Offset: 0x00154978
		// (set) Token: 0x060044A4 RID: 17572 RVA: 0x0002170D File Offset: 0x0001F90D
		public unsafe float SeizureForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RagdollBehaviour.NativeFieldInfoPtr_SeizureForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RagdollBehaviour.NativeFieldInfoPtr_SeizureForce)) = value;
			}
		}

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x060044A5 RID: 17573 RVA: 0x001567A0 File Offset: 0x001549A0
		// (set) Token: 0x060044A6 RID: 17574 RVA: 0x00021728 File Offset: 0x0001F928
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RagdollBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RagdollBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170014A5 RID: 5285
		// (get) Token: 0x060044A7 RID: 17575 RVA: 0x001567C8 File Offset: 0x001549C8
		// (set) Token: 0x060044A8 RID: 17576 RVA: 0x00021743 File Offset: 0x0001F943
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RagdollBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RagdollBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002DDD RID: 11741
		private static readonly IntPtr NativeFieldInfoPtr_Seizure;

		// Token: 0x04002DDE RID: 11742
		private static readonly IntPtr NativeFieldInfoPtr_SeizureForce;

		// Token: 0x04002DDF RID: 11743
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002DE0 RID: 11744
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002DE1 RID: 11745
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04002DE2 RID: 11746
		private static readonly IntPtr NativeMethodInfoPtr_InfrequentUpdate_Private_Void_0;

		// Token: 0x04002DE3 RID: 11747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002DE4 RID: 11748
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002DE5 RID: 11749
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002DE6 RID: 11750
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002DE7 RID: 11751
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
