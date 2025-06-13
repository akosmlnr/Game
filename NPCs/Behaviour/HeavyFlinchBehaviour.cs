using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200037D RID: 893
	public class HeavyFlinchBehaviour : Behaviour
	{
		// Token: 0x06004399 RID: 17305 RVA: 0x00152F80 File Offset: 0x00151180
		// Note: this type is marked as 'beforefieldinit'.
		static HeavyFlinchBehaviour()
		{
			Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "HeavyFlinchBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr);
			HeavyFlinchBehaviour.NativeFieldInfoPtr_FLINCH_DURATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, "FLINCH_DURATION");
			HeavyFlinchBehaviour.NativeFieldInfoPtr_remainingFlinchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, "remainingFlinchTime");
			HeavyFlinchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.HeavyFlinchBehaviourAssembly-CSharp.dll_Excuted");
			HeavyFlinchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.HeavyFlinchBehaviourAssembly-CSharp.dll_Excuted");
			HeavyFlinchBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, 100671609);
			HeavyFlinchBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, 100671610);
			HeavyFlinchBehaviour.NativeMethodInfoPtr_Flinch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, 100671611);
			HeavyFlinchBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, 100671612);
			HeavyFlinchBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, 100671613);
			HeavyFlinchBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, 100671614);
			HeavyFlinchBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, 100671615);
			HeavyFlinchBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr, 100671616);
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x001530A0 File Offset: 0x001512A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157132, XrefRangeEnd = 157136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyFlinchBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x001530DC File Offset: 0x001512DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyFlinchBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x00153118 File Offset: 0x00151318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157136, XrefRangeEnd = 157137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flinch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyFlinchBehaviour.NativeMethodInfoPtr_Flinch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x0015314C File Offset: 0x0015134C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeavyFlinchBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeavyFlinchBehaviour>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeavyFlinchBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x00153188 File Offset: 0x00151388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157137, XrefRangeEnd = 157138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyFlinchBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x001531C4 File Offset: 0x001513C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157138, XrefRangeEnd = 157139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyFlinchBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x00153200 File Offset: 0x00151400
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyFlinchBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x0015323C File Offset: 0x0015143C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeavyFlinchBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x00020FBB File Offset: 0x0001F1BB
		public HeavyFlinchBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x060043A3 RID: 17315 RVA: 0x00153278 File Offset: 0x00151478
		// (set) Token: 0x060043A4 RID: 17316 RVA: 0x00020FC4 File Offset: 0x0001F1C4
		public unsafe static float FLINCH_DURATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(HeavyFlinchBehaviour.NativeFieldInfoPtr_FLINCH_DURATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeavyFlinchBehaviour.NativeFieldInfoPtr_FLINCH_DURATION, (void*)(&value));
			}
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x060043A5 RID: 17317 RVA: 0x00153294 File Offset: 0x00151494
		// (set) Token: 0x060043A6 RID: 17318 RVA: 0x00020FD2 File Offset: 0x0001F1D2
		public unsafe float remainingFlinchTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyFlinchBehaviour.NativeFieldInfoPtr_remainingFlinchTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyFlinchBehaviour.NativeFieldInfoPtr_remainingFlinchTime)) = value;
			}
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x060043A7 RID: 17319 RVA: 0x001532BC File Offset: 0x001514BC
		// (set) Token: 0x060043A8 RID: 17320 RVA: 0x00020FED File Offset: 0x0001F1ED
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyFlinchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyFlinchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x060043A9 RID: 17321 RVA: 0x001532E4 File Offset: 0x001514E4
		// (set) Token: 0x060043AA RID: 17322 RVA: 0x00021008 File Offset: 0x0001F208
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyFlinchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeavyFlinchBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002D2B RID: 11563
		private static readonly IntPtr NativeFieldInfoPtr_FLINCH_DURATION;

		// Token: 0x04002D2C RID: 11564
		private static readonly IntPtr NativeFieldInfoPtr_remainingFlinchTime;

		// Token: 0x04002D2D RID: 11565
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002D2E RID: 11566
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002D2F RID: 11567
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04002D30 RID: 11568
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002D31 RID: 11569
		private static readonly IntPtr NativeMethodInfoPtr_Flinch_Public_Void_0;

		// Token: 0x04002D32 RID: 11570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D33 RID: 11571
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002D34 RID: 11572
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002D35 RID: 11573
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002D36 RID: 11574
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
