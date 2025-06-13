using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x0200040D RID: 1037
	public class ViewmodelSway : PlayerSingleton<ViewmodelSway>
	{
		// Token: 0x060053E8 RID: 21480 RVA: 0x0018EC04 File Offset: 0x0018CE04
		// Note: this type is marked as 'beforefieldinit'.
		static ViewmodelSway()
		{
			Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "ViewmodelSway");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr);
			ViewmodelSway.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "DEBUG");
			ViewmodelSway.NativeFieldInfoPtr_breatheBobbingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "breatheBobbingEnabled");
			ViewmodelSway.NativeFieldInfoPtr_breathingHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "breathingHeightMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_breathingSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "breathingSpeedMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_lastHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "lastHeight");
			ViewmodelSway.NativeFieldInfoPtr_breatheBobPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "breatheBobPos");
			ViewmodelSway.NativeFieldInfoPtr_swayingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "swayingEnabled");
			ViewmodelSway.NativeFieldInfoPtr_horizontalSwayMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "horizontalSwayMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_verticalSwayMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "verticalSwayMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_maxHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "maxHorizontal");
			ViewmodelSway.NativeFieldInfoPtr_maxVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "maxVertical");
			ViewmodelSway.NativeFieldInfoPtr_swaySmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "swaySmooth");
			ViewmodelSway.NativeFieldInfoPtr_returnMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "returnMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_initialPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "initialPos");
			ViewmodelSway.NativeFieldInfoPtr_swayPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "swayPos");
			ViewmodelSway.NativeFieldInfoPtr_walkBobbingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "walkBobbingEnabled");
			ViewmodelSway.NativeFieldInfoPtr_verticalMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "verticalMovement");
			ViewmodelSway.NativeFieldInfoPtr_horizontalMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "horizontalMovement");
			ViewmodelSway.NativeFieldInfoPtr_verticalBobHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "verticalBobHeight");
			ViewmodelSway.NativeFieldInfoPtr_verticalBobSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "verticalBobSpeed");
			ViewmodelSway.NativeFieldInfoPtr_horizontalBobWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "horizontalBobWidth");
			ViewmodelSway.NativeFieldInfoPtr_horizontalBobSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "horizontalBobSpeed");
			ViewmodelSway.NativeFieldInfoPtr_walkBobSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "walkBobSmooth");
			ViewmodelSway.NativeFieldInfoPtr_sprintSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "sprintSpeedMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_walkBobMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "walkBobMultiplier");
			ViewmodelSway.NativeFieldInfoPtr_walkBobPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "walkBobPos");
			ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_vert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "timeSinceWalkStart_vert");
			ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_horiz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "timeSinceWalkStart_horiz");
			ViewmodelSway.NativeFieldInfoPtr_jumpJoltEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpJoltEnabled");
			ViewmodelSway.NativeFieldInfoPtr_jumpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpCurve");
			ViewmodelSway.NativeFieldInfoPtr_jumpJoltTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpJoltTime");
			ViewmodelSway.NativeFieldInfoPtr_jumpJoltHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpJoltHeight");
			ViewmodelSway.NativeFieldInfoPtr_jumpJoltSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpJoltSmooth");
			ViewmodelSway.NativeFieldInfoPtr_equipBopVerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "equipBopVerticalOffset");
			ViewmodelSway.NativeFieldInfoPtr_equipBopTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "equipBopTime");
			ViewmodelSway.NativeFieldInfoPtr_equipBopPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "equipBopPos");
			ViewmodelSway.NativeFieldInfoPtr_timeSinceJumpStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "timeSinceJumpStart");
			ViewmodelSway.NativeFieldInfoPtr_jumpPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "jumpPos");
			ViewmodelSway.NativeFieldInfoPtr_fallOffsetRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "fallOffsetRate");
			ViewmodelSway.NativeFieldInfoPtr_maxFallOffsetAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "maxFallOffsetAmount");
			ViewmodelSway.NativeFieldInfoPtr_fallOffsetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "fallOffsetPos");
			ViewmodelSway.NativeFieldInfoPtr_landCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "landCurve");
			ViewmodelSway.NativeFieldInfoPtr_landJoltTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "landJoltTime");
			ViewmodelSway.NativeFieldInfoPtr_landJoltSmooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "landJoltSmooth");
			ViewmodelSway.NativeFieldInfoPtr_landPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "landPos");
			ViewmodelSway.NativeFieldInfoPtr_timeSinceLanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "timeSinceLanded");
			ViewmodelSway.NativeFieldInfoPtr_landJoltMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, "landJoltMultiplier");
			ViewmodelSway.NativeMethodInfoPtr_get_calculatedJumpJoltHeight_Protected_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673899);
			ViewmodelSway.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673900);
			ViewmodelSway.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673901);
			ViewmodelSway.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673902);
			ViewmodelSway.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673903);
			ViewmodelSway.NativeMethodInfoPtr_InventoryStateChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673904);
			ViewmodelSway.NativeMethodInfoPtr_RefreshViewmodel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673905);
			ViewmodelSway.NativeMethodInfoPtr_BreatheBob_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673906);
			ViewmodelSway.NativeMethodInfoPtr_Sway_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673907);
			ViewmodelSway.NativeMethodInfoPtr_WalkBob_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673908);
			ViewmodelSway.NativeMethodInfoPtr_StartJump_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673909);
			ViewmodelSway.NativeMethodInfoPtr_UpdateJump_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673910);
			ViewmodelSway.NativeMethodInfoPtr_Land_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673911);
			ViewmodelSway.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr, 100673912);
		}

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x060053E9 RID: 21481 RVA: 0x0018F0F8 File Offset: 0x0018D2F8
		public unsafe float calculatedJumpJoltHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_get_calculatedJumpJoltHeight_Protected_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060053EA RID: 21482 RVA: 0x0018F134 File Offset: 0x0018D334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182116, XrefRangeEnd = 182119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewmodelSway.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053EB RID: 21483 RVA: 0x0018F170 File Offset: 0x0018D370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182119, XrefRangeEnd = 182124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewmodelSway.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053EC RID: 21484 RVA: 0x0018F1AC File Offset: 0x0018D3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182124, XrefRangeEnd = 182179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref IsOwner;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ViewmodelSway.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053ED RID: 21485 RVA: 0x0018F1F8 File Offset: 0x0018D3F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182207, RefRangeEnd = 182208, XrefRangeStart = 182179, XrefRangeEnd = 182207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053EE RID: 21486 RVA: 0x0018F22C File Offset: 0x0018D42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182208, XrefRangeEnd = 182209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InventoryStateChanged(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_InventoryStateChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053EF RID: 21487 RVA: 0x0018F26C File Offset: 0x0018D46C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182267, RefRangeEnd = 182269, XrefRangeStart = 182209, XrefRangeEnd = 182267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshViewmodel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_RefreshViewmodel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053F0 RID: 21488 RVA: 0x0018F2A0 File Offset: 0x0018D4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182269, XrefRangeEnd = 182271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BreatheBob()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_BreatheBob_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x0018F2D4 File Offset: 0x0018D4D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182294, RefRangeEnd = 182295, XrefRangeStart = 182271, XrefRangeEnd = 182294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sway()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_Sway_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053F2 RID: 21490 RVA: 0x0018F308 File Offset: 0x0018D508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182323, RefRangeEnd = 182324, XrefRangeStart = 182295, XrefRangeEnd = 182323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WalkBob()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_WalkBob_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053F3 RID: 21491 RVA: 0x0018F33C File Offset: 0x0018D53C
		[CallerCount(0)]
		public unsafe void StartJump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_StartJump_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x0018F370 File Offset: 0x0018D570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182361, RefRangeEnd = 182362, XrefRangeStart = 182324, XrefRangeEnd = 182361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateJump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_UpdateJump_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x0018F3A4 File Offset: 0x0018D5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182362, XrefRangeEnd = 182364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Land()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr_Land_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053F6 RID: 21494 RVA: 0x0018F3D8 File Offset: 0x0018D5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182364, XrefRangeEnd = 182375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ViewmodelSway() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ViewmodelSway>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ViewmodelSway.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060053F7 RID: 21495 RVA: 0x00027BAD File Offset: 0x00025DAD
		public ViewmodelSway(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x060053F8 RID: 21496 RVA: 0x0018F414 File Offset: 0x0018D614
		// (set) Token: 0x060053F9 RID: 21497 RVA: 0x00027BB6 File Offset: 0x00025DB6
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x060053FA RID: 21498 RVA: 0x0018F43C File Offset: 0x0018D63C
		// (set) Token: 0x060053FB RID: 21499 RVA: 0x00027BD1 File Offset: 0x00025DD1
		public unsafe bool breatheBobbingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breatheBobbingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breatheBobbingEnabled)) = value;
			}
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x060053FC RID: 21500 RVA: 0x0018F464 File Offset: 0x0018D664
		// (set) Token: 0x060053FD RID: 21501 RVA: 0x00027BEC File Offset: 0x00025DEC
		public unsafe float breathingHeightMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breathingHeightMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breathingHeightMultiplier)) = value;
			}
		}

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x060053FE RID: 21502 RVA: 0x0018F48C File Offset: 0x0018D68C
		// (set) Token: 0x060053FF RID: 21503 RVA: 0x00027C07 File Offset: 0x00025E07
		public unsafe float breathingSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breathingSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breathingSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x06005400 RID: 21504 RVA: 0x0018F4B4 File Offset: 0x0018D6B4
		// (set) Token: 0x06005401 RID: 21505 RVA: 0x00027C22 File Offset: 0x00025E22
		public unsafe float lastHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_lastHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_lastHeight)) = value;
			}
		}

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x06005402 RID: 21506 RVA: 0x0018F4DC File Offset: 0x0018D6DC
		// (set) Token: 0x06005403 RID: 21507 RVA: 0x00027C3D File Offset: 0x00025E3D
		public unsafe Vector3 breatheBobPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breatheBobPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_breatheBobPos)) = value;
			}
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x06005404 RID: 21508 RVA: 0x0018F504 File Offset: 0x0018D704
		// (set) Token: 0x06005405 RID: 21509 RVA: 0x00027C58 File Offset: 0x00025E58
		public unsafe bool swayingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swayingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swayingEnabled)) = value;
			}
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x06005406 RID: 21510 RVA: 0x0018F52C File Offset: 0x0018D72C
		// (set) Token: 0x06005407 RID: 21511 RVA: 0x00027C73 File Offset: 0x00025E73
		public unsafe float horizontalSwayMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalSwayMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalSwayMultiplier)) = value;
			}
		}

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x06005408 RID: 21512 RVA: 0x0018F554 File Offset: 0x0018D754
		// (set) Token: 0x06005409 RID: 21513 RVA: 0x00027C8E File Offset: 0x00025E8E
		public unsafe float verticalSwayMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalSwayMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalSwayMultiplier)) = value;
			}
		}

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x0600540A RID: 21514 RVA: 0x0018F57C File Offset: 0x0018D77C
		// (set) Token: 0x0600540B RID: 21515 RVA: 0x00027CA9 File Offset: 0x00025EA9
		public unsafe float maxHorizontal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxHorizontal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxHorizontal)) = value;
			}
		}

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x0600540C RID: 21516 RVA: 0x0018F5A4 File Offset: 0x0018D7A4
		// (set) Token: 0x0600540D RID: 21517 RVA: 0x00027CC4 File Offset: 0x00025EC4
		public unsafe float maxVertical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxVertical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxVertical)) = value;
			}
		}

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x0600540E RID: 21518 RVA: 0x0018F5CC File Offset: 0x0018D7CC
		// (set) Token: 0x0600540F RID: 21519 RVA: 0x00027CDF File Offset: 0x00025EDF
		public unsafe float swaySmooth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swaySmooth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swaySmooth)) = value;
			}
		}

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x06005410 RID: 21520 RVA: 0x0018F5F4 File Offset: 0x0018D7F4
		// (set) Token: 0x06005411 RID: 21521 RVA: 0x00027CFA File Offset: 0x00025EFA
		public unsafe float returnMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_returnMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_returnMultiplier)) = value;
			}
		}

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x06005412 RID: 21522 RVA: 0x0018F61C File Offset: 0x0018D81C
		// (set) Token: 0x06005413 RID: 21523 RVA: 0x00027D15 File Offset: 0x00025F15
		public unsafe Vector3 initialPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_initialPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_initialPos)) = value;
			}
		}

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x06005414 RID: 21524 RVA: 0x0018F644 File Offset: 0x0018D844
		// (set) Token: 0x06005415 RID: 21525 RVA: 0x00027D30 File Offset: 0x00025F30
		public unsafe Vector3 swayPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swayPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_swayPos)) = value;
			}
		}

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x06005416 RID: 21526 RVA: 0x0018F66C File Offset: 0x0018D86C
		// (set) Token: 0x06005417 RID: 21527 RVA: 0x00027D4B File Offset: 0x00025F4B
		public unsafe bool walkBobbingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobbingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobbingEnabled)) = value;
			}
		}

		// Token: 0x17001923 RID: 6435
		// (get) Token: 0x06005418 RID: 21528 RVA: 0x0018F694 File Offset: 0x0018D894
		// (set) Token: 0x06005419 RID: 21529 RVA: 0x00027D66 File Offset: 0x00025F66
		public unsafe AnimationCurve verticalMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalMovement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalMovement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001924 RID: 6436
		// (get) Token: 0x0600541A RID: 21530 RVA: 0x0018F6C4 File Offset: 0x0018D8C4
		// (set) Token: 0x0600541B RID: 21531 RVA: 0x00027D85 File Offset: 0x00025F85
		public unsafe AnimationCurve horizontalMovement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalMovement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalMovement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x0600541C RID: 21532 RVA: 0x0018F6F4 File Offset: 0x0018D8F4
		// (set) Token: 0x0600541D RID: 21533 RVA: 0x00027DA4 File Offset: 0x00025FA4
		public unsafe float verticalBobHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalBobHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalBobHeight)) = value;
			}
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x0600541E RID: 21534 RVA: 0x0018F71C File Offset: 0x0018D91C
		// (set) Token: 0x0600541F RID: 21535 RVA: 0x00027DBF File Offset: 0x00025FBF
		public unsafe float verticalBobSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalBobSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_verticalBobSpeed)) = value;
			}
		}

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x06005420 RID: 21536 RVA: 0x0018F744 File Offset: 0x0018D944
		// (set) Token: 0x06005421 RID: 21537 RVA: 0x00027DDA File Offset: 0x00025FDA
		public unsafe float horizontalBobWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalBobWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalBobWidth)) = value;
			}
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x06005422 RID: 21538 RVA: 0x0018F76C File Offset: 0x0018D96C
		// (set) Token: 0x06005423 RID: 21539 RVA: 0x00027DF5 File Offset: 0x00025FF5
		public unsafe float horizontalBobSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalBobSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_horizontalBobSpeed)) = value;
			}
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x06005424 RID: 21540 RVA: 0x0018F794 File Offset: 0x0018D994
		// (set) Token: 0x06005425 RID: 21541 RVA: 0x00027E10 File Offset: 0x00026010
		public unsafe float walkBobSmooth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobSmooth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobSmooth)) = value;
			}
		}

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x06005426 RID: 21542 RVA: 0x0018F7BC File Offset: 0x0018D9BC
		// (set) Token: 0x06005427 RID: 21543 RVA: 0x00027E2B File Offset: 0x0002602B
		public unsafe float sprintSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_sprintSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_sprintSpeedMultiplier)) = value;
			}
		}

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x06005428 RID: 21544 RVA: 0x0018F7E4 File Offset: 0x0018D9E4
		// (set) Token: 0x06005429 RID: 21545 RVA: 0x00027E46 File Offset: 0x00026046
		public unsafe float walkBobMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobMultiplier)) = value;
			}
		}

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x0600542A RID: 21546 RVA: 0x0018F80C File Offset: 0x0018DA0C
		// (set) Token: 0x0600542B RID: 21547 RVA: 0x00027E61 File Offset: 0x00026061
		public unsafe Vector3 walkBobPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_walkBobPos)) = value;
			}
		}

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x0600542C RID: 21548 RVA: 0x0018F834 File Offset: 0x0018DA34
		// (set) Token: 0x0600542D RID: 21549 RVA: 0x00027E7C File Offset: 0x0002607C
		public unsafe float timeSinceWalkStart_vert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_vert);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_vert)) = value;
			}
		}

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x0600542E RID: 21550 RVA: 0x0018F85C File Offset: 0x0018DA5C
		// (set) Token: 0x0600542F RID: 21551 RVA: 0x00027E97 File Offset: 0x00026097
		public unsafe float timeSinceWalkStart_horiz
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_horiz);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceWalkStart_horiz)) = value;
			}
		}

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x06005430 RID: 21552 RVA: 0x0018F884 File Offset: 0x0018DA84
		// (set) Token: 0x06005431 RID: 21553 RVA: 0x00027EB2 File Offset: 0x000260B2
		public unsafe bool jumpJoltEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltEnabled)) = value;
			}
		}

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x06005432 RID: 21554 RVA: 0x0018F8AC File Offset: 0x0018DAAC
		// (set) Token: 0x06005433 RID: 21555 RVA: 0x00027ECD File Offset: 0x000260CD
		public unsafe AnimationCurve jumpCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x06005434 RID: 21556 RVA: 0x0018F8DC File Offset: 0x0018DADC
		// (set) Token: 0x06005435 RID: 21557 RVA: 0x00027EEC File Offset: 0x000260EC
		public unsafe float jumpJoltTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltTime)) = value;
			}
		}

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x06005436 RID: 21558 RVA: 0x0018F904 File Offset: 0x0018DB04
		// (set) Token: 0x06005437 RID: 21559 RVA: 0x00027F07 File Offset: 0x00026107
		public unsafe float jumpJoltHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltHeight)) = value;
			}
		}

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x06005438 RID: 21560 RVA: 0x0018F92C File Offset: 0x0018DB2C
		// (set) Token: 0x06005439 RID: 21561 RVA: 0x00027F22 File Offset: 0x00026122
		public unsafe float jumpJoltSmooth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltSmooth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpJoltSmooth)) = value;
			}
		}

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x0600543A RID: 21562 RVA: 0x0018F954 File Offset: 0x0018DB54
		// (set) Token: 0x0600543B RID: 21563 RVA: 0x00027F3D File Offset: 0x0002613D
		public unsafe float equipBopVerticalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopVerticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopVerticalOffset)) = value;
			}
		}

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x0600543C RID: 21564 RVA: 0x0018F97C File Offset: 0x0018DB7C
		// (set) Token: 0x0600543D RID: 21565 RVA: 0x00027F58 File Offset: 0x00026158
		public unsafe float equipBopTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopTime)) = value;
			}
		}

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x0600543E RID: 21566 RVA: 0x0018F9A4 File Offset: 0x0018DBA4
		// (set) Token: 0x0600543F RID: 21567 RVA: 0x00027F73 File Offset: 0x00026173
		public unsafe Vector3 equipBopPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_equipBopPos)) = value;
			}
		}

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x06005440 RID: 21568 RVA: 0x0018F9CC File Offset: 0x0018DBCC
		// (set) Token: 0x06005441 RID: 21569 RVA: 0x00027F8E File Offset: 0x0002618E
		public unsafe float timeSinceJumpStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceJumpStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceJumpStart)) = value;
			}
		}

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x06005442 RID: 21570 RVA: 0x0018F9F4 File Offset: 0x0018DBF4
		// (set) Token: 0x06005443 RID: 21571 RVA: 0x00027FA9 File Offset: 0x000261A9
		public unsafe Vector3 jumpPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_jumpPos)) = value;
			}
		}

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x06005444 RID: 21572 RVA: 0x0018FA1C File Offset: 0x0018DC1C
		// (set) Token: 0x06005445 RID: 21573 RVA: 0x00027FC4 File Offset: 0x000261C4
		public unsafe float fallOffsetRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_fallOffsetRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_fallOffsetRate)) = value;
			}
		}

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x06005446 RID: 21574 RVA: 0x0018FA44 File Offset: 0x0018DC44
		// (set) Token: 0x06005447 RID: 21575 RVA: 0x00027FDF File Offset: 0x000261DF
		public unsafe float maxFallOffsetAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxFallOffsetAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_maxFallOffsetAmount)) = value;
			}
		}

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x06005448 RID: 21576 RVA: 0x0018FA6C File Offset: 0x0018DC6C
		// (set) Token: 0x06005449 RID: 21577 RVA: 0x00027FFA File Offset: 0x000261FA
		public unsafe Vector3 fallOffsetPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_fallOffsetPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_fallOffsetPos)) = value;
			}
		}

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x0600544A RID: 21578 RVA: 0x0018FA94 File Offset: 0x0018DC94
		// (set) Token: 0x0600544B RID: 21579 RVA: 0x00028015 File Offset: 0x00026215
		public unsafe AnimationCurve landCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x0600544C RID: 21580 RVA: 0x0018FAC4 File Offset: 0x0018DCC4
		// (set) Token: 0x0600544D RID: 21581 RVA: 0x00028034 File Offset: 0x00026234
		public unsafe float landJoltTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltTime)) = value;
			}
		}

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x0600544E RID: 21582 RVA: 0x0018FAEC File Offset: 0x0018DCEC
		// (set) Token: 0x0600544F RID: 21583 RVA: 0x0002804F File Offset: 0x0002624F
		public unsafe float landJoltSmooth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltSmooth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltSmooth)) = value;
			}
		}

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x06005450 RID: 21584 RVA: 0x0018FB14 File Offset: 0x0018DD14
		// (set) Token: 0x06005451 RID: 21585 RVA: 0x0002806A File Offset: 0x0002626A
		public unsafe Vector3 landPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landPos)) = value;
			}
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x06005452 RID: 21586 RVA: 0x0018FB3C File Offset: 0x0018DD3C
		// (set) Token: 0x06005453 RID: 21587 RVA: 0x00028085 File Offset: 0x00026285
		public unsafe float timeSinceLanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceLanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_timeSinceLanded)) = value;
			}
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x06005454 RID: 21588 RVA: 0x0018FB64 File Offset: 0x0018DD64
		// (set) Token: 0x06005455 RID: 21589 RVA: 0x000280A0 File Offset: 0x000262A0
		public unsafe float landJoltMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ViewmodelSway.NativeFieldInfoPtr_landJoltMultiplier)) = value;
			}
		}

		// Token: 0x040038E8 RID: 14568
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x040038E9 RID: 14569
		private static readonly IntPtr NativeFieldInfoPtr_breatheBobbingEnabled;

		// Token: 0x040038EA RID: 14570
		private static readonly IntPtr NativeFieldInfoPtr_breathingHeightMultiplier;

		// Token: 0x040038EB RID: 14571
		private static readonly IntPtr NativeFieldInfoPtr_breathingSpeedMultiplier;

		// Token: 0x040038EC RID: 14572
		private static readonly IntPtr NativeFieldInfoPtr_lastHeight;

		// Token: 0x040038ED RID: 14573
		private static readonly IntPtr NativeFieldInfoPtr_breatheBobPos;

		// Token: 0x040038EE RID: 14574
		private static readonly IntPtr NativeFieldInfoPtr_swayingEnabled;

		// Token: 0x040038EF RID: 14575
		private static readonly IntPtr NativeFieldInfoPtr_horizontalSwayMultiplier;

		// Token: 0x040038F0 RID: 14576
		private static readonly IntPtr NativeFieldInfoPtr_verticalSwayMultiplier;

		// Token: 0x040038F1 RID: 14577
		private static readonly IntPtr NativeFieldInfoPtr_maxHorizontal;

		// Token: 0x040038F2 RID: 14578
		private static readonly IntPtr NativeFieldInfoPtr_maxVertical;

		// Token: 0x040038F3 RID: 14579
		private static readonly IntPtr NativeFieldInfoPtr_swaySmooth;

		// Token: 0x040038F4 RID: 14580
		private static readonly IntPtr NativeFieldInfoPtr_returnMultiplier;

		// Token: 0x040038F5 RID: 14581
		private static readonly IntPtr NativeFieldInfoPtr_initialPos;

		// Token: 0x040038F6 RID: 14582
		private static readonly IntPtr NativeFieldInfoPtr_swayPos;

		// Token: 0x040038F7 RID: 14583
		private static readonly IntPtr NativeFieldInfoPtr_walkBobbingEnabled;

		// Token: 0x040038F8 RID: 14584
		private static readonly IntPtr NativeFieldInfoPtr_verticalMovement;

		// Token: 0x040038F9 RID: 14585
		private static readonly IntPtr NativeFieldInfoPtr_horizontalMovement;

		// Token: 0x040038FA RID: 14586
		private static readonly IntPtr NativeFieldInfoPtr_verticalBobHeight;

		// Token: 0x040038FB RID: 14587
		private static readonly IntPtr NativeFieldInfoPtr_verticalBobSpeed;

		// Token: 0x040038FC RID: 14588
		private static readonly IntPtr NativeFieldInfoPtr_horizontalBobWidth;

		// Token: 0x040038FD RID: 14589
		private static readonly IntPtr NativeFieldInfoPtr_horizontalBobSpeed;

		// Token: 0x040038FE RID: 14590
		private static readonly IntPtr NativeFieldInfoPtr_walkBobSmooth;

		// Token: 0x040038FF RID: 14591
		private static readonly IntPtr NativeFieldInfoPtr_sprintSpeedMultiplier;

		// Token: 0x04003900 RID: 14592
		private static readonly IntPtr NativeFieldInfoPtr_walkBobMultiplier;

		// Token: 0x04003901 RID: 14593
		private static readonly IntPtr NativeFieldInfoPtr_walkBobPos;

		// Token: 0x04003902 RID: 14594
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceWalkStart_vert;

		// Token: 0x04003903 RID: 14595
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceWalkStart_horiz;

		// Token: 0x04003904 RID: 14596
		private static readonly IntPtr NativeFieldInfoPtr_jumpJoltEnabled;

		// Token: 0x04003905 RID: 14597
		private static readonly IntPtr NativeFieldInfoPtr_jumpCurve;

		// Token: 0x04003906 RID: 14598
		private static readonly IntPtr NativeFieldInfoPtr_jumpJoltTime;

		// Token: 0x04003907 RID: 14599
		private static readonly IntPtr NativeFieldInfoPtr_jumpJoltHeight;

		// Token: 0x04003908 RID: 14600
		private static readonly IntPtr NativeFieldInfoPtr_jumpJoltSmooth;

		// Token: 0x04003909 RID: 14601
		private static readonly IntPtr NativeFieldInfoPtr_equipBopVerticalOffset;

		// Token: 0x0400390A RID: 14602
		private static readonly IntPtr NativeFieldInfoPtr_equipBopTime;

		// Token: 0x0400390B RID: 14603
		private static readonly IntPtr NativeFieldInfoPtr_equipBopPos;

		// Token: 0x0400390C RID: 14604
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceJumpStart;

		// Token: 0x0400390D RID: 14605
		private static readonly IntPtr NativeFieldInfoPtr_jumpPos;

		// Token: 0x0400390E RID: 14606
		private static readonly IntPtr NativeFieldInfoPtr_fallOffsetRate;

		// Token: 0x0400390F RID: 14607
		private static readonly IntPtr NativeFieldInfoPtr_maxFallOffsetAmount;

		// Token: 0x04003910 RID: 14608
		private static readonly IntPtr NativeFieldInfoPtr_fallOffsetPos;

		// Token: 0x04003911 RID: 14609
		private static readonly IntPtr NativeFieldInfoPtr_landCurve;

		// Token: 0x04003912 RID: 14610
		private static readonly IntPtr NativeFieldInfoPtr_landJoltTime;

		// Token: 0x04003913 RID: 14611
		private static readonly IntPtr NativeFieldInfoPtr_landJoltSmooth;

		// Token: 0x04003914 RID: 14612
		private static readonly IntPtr NativeFieldInfoPtr_landPos;

		// Token: 0x04003915 RID: 14613
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLanded;

		// Token: 0x04003916 RID: 14614
		private static readonly IntPtr NativeFieldInfoPtr_landJoltMultiplier;

		// Token: 0x04003917 RID: 14615
		private static readonly IntPtr NativeMethodInfoPtr_get_calculatedJumpJoltHeight_Protected_get_Single_0;

		// Token: 0x04003918 RID: 14616
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003919 RID: 14617
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400391A RID: 14618
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400391B RID: 14619
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x0400391C RID: 14620
		private static readonly IntPtr NativeMethodInfoPtr_InventoryStateChanged_Private_Void_Boolean_0;

		// Token: 0x0400391D RID: 14621
		private static readonly IntPtr NativeMethodInfoPtr_RefreshViewmodel_Public_Void_0;

		// Token: 0x0400391E RID: 14622
		private static readonly IntPtr NativeMethodInfoPtr_BreatheBob_Protected_Void_0;

		// Token: 0x0400391F RID: 14623
		private static readonly IntPtr NativeMethodInfoPtr_Sway_Protected_Void_0;

		// Token: 0x04003920 RID: 14624
		private static readonly IntPtr NativeMethodInfoPtr_WalkBob_Protected_Void_0;

		// Token: 0x04003921 RID: 14625
		private static readonly IntPtr NativeMethodInfoPtr_StartJump_Protected_Void_0;

		// Token: 0x04003922 RID: 14626
		private static readonly IntPtr NativeMethodInfoPtr_UpdateJump_Protected_Void_0;

		// Token: 0x04003923 RID: 14627
		private static readonly IntPtr NativeMethodInfoPtr_Land_Protected_Void_0;

		// Token: 0x04003924 RID: 14628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
