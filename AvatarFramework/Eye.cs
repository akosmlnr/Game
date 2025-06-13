using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x02000619 RID: 1561
	public class Eye : MonoBehaviour
	{
		// Token: 0x06008870 RID: 34928 RVA: 0x00243F20 File Offset: 0x00242120
		// Note: this type is marked as 'beforefieldinit'.
		static Eye()
		{
			Il2CppClassPointerStore<Eye>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Eye");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye>.NativeClassPtr);
			Eye.NativeFieldInfoPtr_PupilLookSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "PupilLookSpeed");
			Eye.NativeFieldInfoPtr_defaultScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "defaultScale");
			Eye.NativeFieldInfoPtr_maxRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "maxRotation");
			Eye.NativeFieldInfoPtr_minRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "minRotation");
			Eye.NativeFieldInfoPtr__CurrentConfiguration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "<CurrentConfiguration>k__BackingField");
			Eye.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "Container");
			Eye.NativeFieldInfoPtr_TopLidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "TopLidContainer");
			Eye.NativeFieldInfoPtr_BottomLidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "BottomLidContainer");
			Eye.NativeFieldInfoPtr_PupilContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "PupilContainer");
			Eye.NativeFieldInfoPtr_TopLidRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "TopLidRend");
			Eye.NativeFieldInfoPtr_BottomLidRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "BottomLidRend");
			Eye.NativeFieldInfoPtr_EyeBallRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "EyeBallRend");
			Eye.NativeFieldInfoPtr_EyeLookOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "EyeLookOrigin");
			Eye.NativeFieldInfoPtr_EyeLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "EyeLight");
			Eye.NativeFieldInfoPtr_PupilRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "PupilRend");
			Eye.NativeFieldInfoPtr_blinkRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "blinkRoutine");
			Eye.NativeFieldInfoPtr_stateRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "stateRoutine");
			Eye.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "avatar");
			Eye.NativeFieldInfoPtr_defaultEyeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "defaultEyeColor");
			Eye.NativeFieldInfoPtr_AngleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye>.NativeClassPtr, "AngleOffset");
			Eye.NativeMethodInfoPtr_get_CurrentConfiguration_Public_get_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680435);
			Eye.NativeMethodInfoPtr_set_CurrentConfiguration_Protected_set_Void_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680436);
			Eye.NativeMethodInfoPtr_get_IsBlinking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680437);
			Eye.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680438);
			Eye.NativeMethodInfoPtr_SetSize_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680439);
			Eye.NativeMethodInfoPtr_SetLidColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680440);
			Eye.NativeMethodInfoPtr_SetEyeballMaterial_Public_Void_Material_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680441);
			Eye.NativeMethodInfoPtr_SetEyeballColor_Public_Void_Color_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680442);
			Eye.NativeMethodInfoPtr_ResetEyeballColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680443);
			Eye.NativeMethodInfoPtr_ConfigureEyeLight_Public_Void_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680444);
			Eye.NativeMethodInfoPtr_SetDilation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680445);
			Eye.NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680446);
			Eye.NativeMethodInfoPtr_StopExistingRoutines_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680447);
			Eye.NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680448);
			Eye.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680449);
			Eye.NativeMethodInfoPtr_Blink_Public_Void_Single_EyeLidConfiguration_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680450);
			Eye.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye>.NativeClassPtr, 100680451);
		}

		// Token: 0x1700294E RID: 10574
		// (get) Token: 0x06008871 RID: 34929 RVA: 0x00244234 File Offset: 0x00242434
		// (set) Token: 0x06008872 RID: 34930 RVA: 0x00244270 File Offset: 0x00242470
		public unsafe Eye.EyeLidConfiguration CurrentConfiguration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_get_CurrentConfiguration_Public_get_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_set_CurrentConfiguration_Protected_set_Void_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700294F RID: 10575
		// (get) Token: 0x06008873 RID: 34931 RVA: 0x002442B0 File Offset: 0x002424B0
		public unsafe bool IsBlinking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_get_IsBlinking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06008874 RID: 34932 RVA: 0x002442EC File Offset: 0x002424EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254665, XrefRangeEnd = 254669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008875 RID: 34933 RVA: 0x00244320 File Offset: 0x00242520
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254674, RefRangeEnd = 254676, XrefRangeStart = 254669, XrefRangeEnd = 254674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSize(float size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref size;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetSize_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008876 RID: 34934 RVA: 0x00244360 File Offset: 0x00242560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254676, XrefRangeEnd = 254680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLidColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetLidColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008877 RID: 34935 RVA: 0x002443A0 File Offset: 0x002425A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254680, XrefRangeEnd = 254682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeballMaterial(Material mat, Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref col;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetEyeballMaterial_Public_Void_Material_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008878 RID: 34936 RVA: 0x002443F0 File Offset: 0x002425F0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 254688, RefRangeEnd = 254700, XrefRangeStart = 254682, XrefRangeEnd = 254688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeballColor(Color col, float emission = 0.115f, bool writeDefault = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref emission;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref writeDefault;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetEyeballColor_Public_Void_Color_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008879 RID: 34937 RVA: 0x0024444C File Offset: 0x0024264C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 254706, RefRangeEnd = 254710, XrefRangeStart = 254700, XrefRangeEnd = 254706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeballColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_ResetEyeballColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600887A RID: 34938 RVA: 0x00244480 File Offset: 0x00242680
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254719, RefRangeEnd = 254721, XrefRangeStart = 254710, XrefRangeEnd = 254719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureEyeLight(Color color, float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref intensity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_ConfigureEyeLight_Public_Void_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600887B RID: 34939 RVA: 0x002444CC File Offset: 0x002426CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254721, XrefRangeEnd = 254723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDilation(float dil)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref dil;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetDilation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600887C RID: 34940 RVA: 0x0024450C File Offset: 0x0024270C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254744, RefRangeEnd = 254746, XrefRangeStart = 254723, XrefRangeEnd = 254744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeLidState(Eye.EyeLidConfiguration config, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref config;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref time;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600887D RID: 34941 RVA: 0x00244558 File Offset: 0x00242758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254746, XrefRangeEnd = 254748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopExistingRoutines()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_StopExistingRoutines_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600887E RID: 34942 RVA: 0x0024458C File Offset: 0x0024278C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 254777, RefRangeEnd = 254791, XrefRangeStart = 254748, XrefRangeEnd = 254777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeLidState(Eye.EyeLidConfiguration config, bool debug = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref config;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref debug;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600887F RID: 34943 RVA: 0x002445D8 File Offset: 0x002427D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254817, RefRangeEnd = 254819, XrefRangeStart = 254791, XrefRangeEnd = 254817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 position, bool instant = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref instant;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008880 RID: 34944 RVA: 0x00244624 File Offset: 0x00242824
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 254843, RefRangeEnd = 254847, XrefRangeStart = 254819, XrefRangeEnd = 254843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blink(float blinkDuration, Eye.EyeLidConfiguration endState, bool debug = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref blinkDuration;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref endState;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref debug;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr_Blink_Public_Void_Single_EyeLidConfiguration_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008881 RID: 34945 RVA: 0x00244680 File Offset: 0x00242880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254847, XrefRangeEnd = 254850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Eye() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008882 RID: 34946 RVA: 0x00040902 File Offset: 0x0003EB02
		public Eye(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700293A RID: 10554
		// (get) Token: 0x06008883 RID: 34947 RVA: 0x002446BC File Offset: 0x002428BC
		// (set) Token: 0x06008884 RID: 34948 RVA: 0x0004090B File Offset: 0x0003EB0B
		public unsafe static float PupilLookSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Eye.NativeFieldInfoPtr_PupilLookSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eye.NativeFieldInfoPtr_PupilLookSpeed, (void*)(&value));
			}
		}

		// Token: 0x1700293B RID: 10555
		// (get) Token: 0x06008885 RID: 34949 RVA: 0x002446D8 File Offset: 0x002428D8
		// (set) Token: 0x06008886 RID: 34950 RVA: 0x00040919 File Offset: 0x0003EB19
		public unsafe static Vector3 defaultScale
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Eye.NativeFieldInfoPtr_defaultScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eye.NativeFieldInfoPtr_defaultScale, (void*)(&value));
			}
		}

		// Token: 0x1700293C RID: 10556
		// (get) Token: 0x06008887 RID: 34951 RVA: 0x002446F4 File Offset: 0x002428F4
		// (set) Token: 0x06008888 RID: 34952 RVA: 0x00040927 File Offset: 0x0003EB27
		public unsafe static Vector3 maxRotation
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Eye.NativeFieldInfoPtr_maxRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eye.NativeFieldInfoPtr_maxRotation, (void*)(&value));
			}
		}

		// Token: 0x1700293D RID: 10557
		// (get) Token: 0x06008889 RID: 34953 RVA: 0x00244710 File Offset: 0x00242910
		// (set) Token: 0x0600888A RID: 34954 RVA: 0x00040935 File Offset: 0x0003EB35
		public unsafe static Vector3 minRotation
		{
			get
			{
				Vector3 result;
				IL2CPP.il2cpp_field_static_get_value(Eye.NativeFieldInfoPtr_minRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eye.NativeFieldInfoPtr_minRotation, (void*)(&value));
			}
		}

		// Token: 0x1700293E RID: 10558
		// (get) Token: 0x0600888B RID: 34955 RVA: 0x0024472C File Offset: 0x0024292C
		// (set) Token: 0x0600888C RID: 34956 RVA: 0x00040943 File Offset: 0x0003EB43
		public unsafe Eye.EyeLidConfiguration _CurrentConfiguration_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr__CurrentConfiguration_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr__CurrentConfiguration_k__BackingField)) = value;
			}
		}

		// Token: 0x1700293F RID: 10559
		// (get) Token: 0x0600888D RID: 34957 RVA: 0x00244754 File Offset: 0x00242954
		// (set) Token: 0x0600888E RID: 34958 RVA: 0x0004095E File Offset: 0x0003EB5E
		public unsafe Transform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002940 RID: 10560
		// (get) Token: 0x0600888F RID: 34959 RVA: 0x00244784 File Offset: 0x00242984
		// (set) Token: 0x06008890 RID: 34960 RVA: 0x0004097D File Offset: 0x0003EB7D
		public unsafe Transform TopLidContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_TopLidContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_TopLidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002941 RID: 10561
		// (get) Token: 0x06008891 RID: 34961 RVA: 0x002447B4 File Offset: 0x002429B4
		// (set) Token: 0x06008892 RID: 34962 RVA: 0x0004099C File Offset: 0x0003EB9C
		public unsafe Transform BottomLidContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_BottomLidContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_BottomLidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002942 RID: 10562
		// (get) Token: 0x06008893 RID: 34963 RVA: 0x002447E4 File Offset: 0x002429E4
		// (set) Token: 0x06008894 RID: 34964 RVA: 0x000409BB File Offset: 0x0003EBBB
		public unsafe Transform PupilContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_PupilContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_PupilContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002943 RID: 10563
		// (get) Token: 0x06008895 RID: 34965 RVA: 0x00244814 File Offset: 0x00242A14
		// (set) Token: 0x06008896 RID: 34966 RVA: 0x000409DA File Offset: 0x0003EBDA
		public unsafe MeshRenderer TopLidRend
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_TopLidRend);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_TopLidRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002944 RID: 10564
		// (get) Token: 0x06008897 RID: 34967 RVA: 0x00244844 File Offset: 0x00242A44
		// (set) Token: 0x06008898 RID: 34968 RVA: 0x000409F9 File Offset: 0x0003EBF9
		public unsafe MeshRenderer BottomLidRend
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_BottomLidRend);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_BottomLidRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002945 RID: 10565
		// (get) Token: 0x06008899 RID: 34969 RVA: 0x00244874 File Offset: 0x00242A74
		// (set) Token: 0x0600889A RID: 34970 RVA: 0x00040A18 File Offset: 0x0003EC18
		public unsafe MeshRenderer EyeBallRend
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeBallRend);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeBallRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002946 RID: 10566
		// (get) Token: 0x0600889B RID: 34971 RVA: 0x002448A4 File Offset: 0x00242AA4
		// (set) Token: 0x0600889C RID: 34972 RVA: 0x00040A37 File Offset: 0x0003EC37
		public unsafe Transform EyeLookOrigin
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeLookOrigin);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeLookOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002947 RID: 10567
		// (get) Token: 0x0600889D RID: 34973 RVA: 0x002448D4 File Offset: 0x00242AD4
		// (set) Token: 0x0600889E RID: 34974 RVA: 0x00040A56 File Offset: 0x0003EC56
		public unsafe OptimizedLight EyeLight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeLight);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_EyeLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002948 RID: 10568
		// (get) Token: 0x0600889F RID: 34975 RVA: 0x00244904 File Offset: 0x00242B04
		// (set) Token: 0x060088A0 RID: 34976 RVA: 0x00040A75 File Offset: 0x0003EC75
		public unsafe SkinnedMeshRenderer PupilRend
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_PupilRend);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_PupilRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002949 RID: 10569
		// (get) Token: 0x060088A1 RID: 34977 RVA: 0x00244934 File Offset: 0x00242B34
		// (set) Token: 0x060088A2 RID: 34978 RVA: 0x00040A94 File Offset: 0x0003EC94
		public unsafe Coroutine blinkRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_blinkRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_blinkRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700294A RID: 10570
		// (get) Token: 0x060088A3 RID: 34979 RVA: 0x00244964 File Offset: 0x00242B64
		// (set) Token: 0x060088A4 RID: 34980 RVA: 0x00040AB3 File Offset: 0x0003ECB3
		public unsafe Coroutine stateRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_stateRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_stateRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700294B RID: 10571
		// (get) Token: 0x060088A5 RID: 34981 RVA: 0x00244994 File Offset: 0x00242B94
		// (set) Token: 0x060088A6 RID: 34982 RVA: 0x00040AD2 File Offset: 0x0003ECD2
		public unsafe Avatar avatar
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_avatar);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700294C RID: 10572
		// (get) Token: 0x060088A7 RID: 34983 RVA: 0x002449C4 File Offset: 0x00242BC4
		// (set) Token: 0x060088A8 RID: 34984 RVA: 0x00040AF1 File Offset: 0x0003ECF1
		public unsafe Color defaultEyeColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_defaultEyeColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_defaultEyeColor)) = value;
			}
		}

		// Token: 0x1700294D RID: 10573
		// (get) Token: 0x060088A9 RID: 34985 RVA: 0x002449EC File Offset: 0x00242BEC
		// (set) Token: 0x060088AA RID: 34986 RVA: 0x00040B0C File Offset: 0x0003ED0C
		public unsafe Vector2 AngleOffset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_AngleOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.NativeFieldInfoPtr_AngleOffset)) = value;
			}
		}

		// Token: 0x04005CEB RID: 23787
		private static readonly System.IntPtr NativeFieldInfoPtr_PupilLookSpeed;

		// Token: 0x04005CEC RID: 23788
		private static readonly System.IntPtr NativeFieldInfoPtr_defaultScale;

		// Token: 0x04005CED RID: 23789
		private static readonly System.IntPtr NativeFieldInfoPtr_maxRotation;

		// Token: 0x04005CEE RID: 23790
		private static readonly System.IntPtr NativeFieldInfoPtr_minRotation;

		// Token: 0x04005CEF RID: 23791
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentConfiguration_k__BackingField;

		// Token: 0x04005CF0 RID: 23792
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005CF1 RID: 23793
		private static readonly System.IntPtr NativeFieldInfoPtr_TopLidContainer;

		// Token: 0x04005CF2 RID: 23794
		private static readonly System.IntPtr NativeFieldInfoPtr_BottomLidContainer;

		// Token: 0x04005CF3 RID: 23795
		private static readonly System.IntPtr NativeFieldInfoPtr_PupilContainer;

		// Token: 0x04005CF4 RID: 23796
		private static readonly System.IntPtr NativeFieldInfoPtr_TopLidRend;

		// Token: 0x04005CF5 RID: 23797
		private static readonly System.IntPtr NativeFieldInfoPtr_BottomLidRend;

		// Token: 0x04005CF6 RID: 23798
		private static readonly System.IntPtr NativeFieldInfoPtr_EyeBallRend;

		// Token: 0x04005CF7 RID: 23799
		private static readonly System.IntPtr NativeFieldInfoPtr_EyeLookOrigin;

		// Token: 0x04005CF8 RID: 23800
		private static readonly System.IntPtr NativeFieldInfoPtr_EyeLight;

		// Token: 0x04005CF9 RID: 23801
		private static readonly System.IntPtr NativeFieldInfoPtr_PupilRend;

		// Token: 0x04005CFA RID: 23802
		private static readonly System.IntPtr NativeFieldInfoPtr_blinkRoutine;

		// Token: 0x04005CFB RID: 23803
		private static readonly System.IntPtr NativeFieldInfoPtr_stateRoutine;

		// Token: 0x04005CFC RID: 23804
		private static readonly System.IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005CFD RID: 23805
		private static readonly System.IntPtr NativeFieldInfoPtr_defaultEyeColor;

		// Token: 0x04005CFE RID: 23806
		private static readonly System.IntPtr NativeFieldInfoPtr_AngleOffset;

		// Token: 0x04005CFF RID: 23807
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentConfiguration_Public_get_EyeLidConfiguration_0;

		// Token: 0x04005D00 RID: 23808
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentConfiguration_Protected_set_Void_EyeLidConfiguration_0;

		// Token: 0x04005D01 RID: 23809
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsBlinking_Public_get_Boolean_0;

		// Token: 0x04005D02 RID: 23810
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005D03 RID: 23811
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSize_Public_Void_Single_0;

		// Token: 0x04005D04 RID: 23812
		private static readonly System.IntPtr NativeMethodInfoPtr_SetLidColor_Public_Void_Color_0;

		// Token: 0x04005D05 RID: 23813
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEyeballMaterial_Public_Void_Material_Color_0;

		// Token: 0x04005D06 RID: 23814
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEyeballColor_Public_Void_Color_Single_Boolean_0;

		// Token: 0x04005D07 RID: 23815
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetEyeballColor_Public_Void_0;

		// Token: 0x04005D08 RID: 23816
		private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureEyeLight_Public_Void_Color_Single_0;

		// Token: 0x04005D09 RID: 23817
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDilation_Public_Void_Single_0;

		// Token: 0x04005D0A RID: 23818
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Single_0;

		// Token: 0x04005D0B RID: 23819
		private static readonly System.IntPtr NativeMethodInfoPtr_StopExistingRoutines_Private_Void_0;

		// Token: 0x04005D0C RID: 23820
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEyeLidState_Public_Void_EyeLidConfiguration_Boolean_0;

		// Token: 0x04005D0D RID: 23821
		private static readonly System.IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0;

		// Token: 0x04005D0E RID: 23822
		private static readonly System.IntPtr NativeMethodInfoPtr_Blink_Public_Void_Single_EyeLidConfiguration_Boolean_0;

		// Token: 0x04005D0F RID: 23823
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B3D RID: 2877
		[System.Serializable]
		[StructLayout(LayoutKind.Explicit)]
		public struct EyeLidConfiguration
		{
			// Token: 0x0600DABC RID: 55996 RVA: 0x003442A8 File Offset: 0x003424A8
			// Note: this type is marked as 'beforefieldinit'.
			static EyeLidConfiguration()
			{
				Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye>.NativeClassPtr, "EyeLidConfiguration");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr);
				Eye.EyeLidConfiguration.NativeFieldInfoPtr_topLidOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, "topLidOpen");
				Eye.EyeLidConfiguration.NativeFieldInfoPtr_bottomLidOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, "bottomLidOpen");
				Eye.EyeLidConfiguration.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, 100680453);
				Eye.EyeLidConfiguration.NativeMethodInfoPtr_Lerp_Public_Static_EyeLidConfiguration_EyeLidConfiguration_EyeLidConfiguration_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, 100680454);
			}

			// Token: 0x0600DABD RID: 55997 RVA: 0x00344324 File Offset: 0x00342524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254615, XrefRangeEnd = 254622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Eye.EyeLidConfiguration.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}

			// Token: 0x0600DABE RID: 55998 RVA: 0x00344350 File Offset: 0x00342550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254622, XrefRangeEnd = 254624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Eye.EyeLidConfiguration Lerp(Eye.EyeLidConfiguration start, Eye.EyeLidConfiguration end, float lerp)
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref start;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref end;
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lerp;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Eye.EyeLidConfiguration.NativeMethodInfoPtr_Lerp_Public_Static_EyeLidConfiguration_EyeLidConfiguration_EyeLidConfiguration_Single_0, 0, (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DABF RID: 55999 RVA: 0x0006A17F File Offset: 0x0006837F
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Eye.EyeLidConfiguration>.NativeClassPtr, ref this));
			}

			// Token: 0x04009333 RID: 37683
			private static readonly System.IntPtr NativeFieldInfoPtr_topLidOpen;

			// Token: 0x04009334 RID: 37684
			private static readonly System.IntPtr NativeFieldInfoPtr_bottomLidOpen;

			// Token: 0x04009335 RID: 37685
			private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04009336 RID: 37686
			private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_EyeLidConfiguration_EyeLidConfiguration_EyeLidConfiguration_Single_0;

			// Token: 0x04009337 RID: 37687
			[FieldOffset(0)]
			public float topLidOpen;

			// Token: 0x04009338 RID: 37688
			[FieldOffset(4)]
			public float bottomLidOpen;
		}

		// Token: 0x02000B3E RID: 2878
		[ObfuscatedName("ScheduleOne.AvatarFramework.Eye+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DAC0 RID: 56000 RVA: 0x003443AC File Offset: 0x003425AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr);
				Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_startConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "startConfig");
				Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "config");
				Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "time");
				Eye.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "<>4__this");
				Eye.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, 100680455);
				Eye.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, 100680456);
			}

			// Token: 0x0600DAC1 RID: 56001 RVA: 0x00344450 File Offset: 0x00342650
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DAC2 RID: 56002 RVA: 0x0034448C File Offset: 0x0034268C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254639, XrefRangeEnd = 254644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DAC3 RID: 56003 RVA: 0x0006A191 File Offset: 0x00068391
			public __c__DisplayClass34_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004379 RID: 17273
			// (get) Token: 0x0600DAC4 RID: 56004 RVA: 0x003444CC File Offset: 0x003426CC
			// (set) Token: 0x0600DAC5 RID: 56005 RVA: 0x0006A19A File Offset: 0x0006839A
			public unsafe Eye.EyeLidConfiguration startConfig
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_startConfig);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_startConfig)) = value;
				}
			}

			// Token: 0x1700437A RID: 17274
			// (get) Token: 0x0600DAC6 RID: 56006 RVA: 0x003444F4 File Offset: 0x003426F4
			// (set) Token: 0x0600DAC7 RID: 56007 RVA: 0x0006A1B5 File Offset: 0x000683B5
			public unsafe Eye.EyeLidConfiguration config
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_config);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_config)) = value;
				}
			}

			// Token: 0x1700437B RID: 17275
			// (get) Token: 0x0600DAC8 RID: 56008 RVA: 0x0034451C File Offset: 0x0034271C
			// (set) Token: 0x0600DAC9 RID: 56009 RVA: 0x0006A1D0 File Offset: 0x000683D0
			public unsafe float time
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x1700437C RID: 17276
			// (get) Token: 0x0600DACA RID: 56010 RVA: 0x00344544 File Offset: 0x00342744
			// (set) Token: 0x0600DACB RID: 56011 RVA: 0x0006A1EB File Offset: 0x000683EB
			public unsafe Eye __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009339 RID: 37689
			private static readonly System.IntPtr NativeFieldInfoPtr_startConfig;

			// Token: 0x0400933A RID: 37690
			private static readonly System.IntPtr NativeFieldInfoPtr_config;

			// Token: 0x0400933B RID: 37691
			private static readonly System.IntPtr NativeFieldInfoPtr_time;

			// Token: 0x0400933C RID: 37692
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400933D RID: 37693
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400933E RID: 37694
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CC1 RID: 3265
			[ObfuscatedName("ScheduleOne.AvatarFramework.Eye+<>c__DisplayClass34_0+<<SetEyeLidState>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EA07 RID: 59911 RVA: 0x003700C8 File Offset: 0x0036E2C8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0>.NativeClassPtr, "<<SetEyeLidState>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<i>5__2");
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680457);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680458);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680459);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680460);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680461);
					Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100680462);
				}

				// Token: 0x0600EA08 RID: 59912 RVA: 0x003701BC File Offset: 0x0036E3BC
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA09 RID: 59913 RVA: 0x00370204 File Offset: 0x0036E404
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA0A RID: 59914 RVA: 0x00370238 File Offset: 0x0036E438
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254624, XrefRangeEnd = 254634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004860 RID: 18528
				// (get) Token: 0x0600EA0B RID: 59915 RVA: 0x00370274 File Offset: 0x0036E474
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA0C RID: 59916 RVA: 0x003702B4 File Offset: 0x0036E4B4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254634, XrefRangeEnd = 254639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004861 RID: 18529
				// (get) Token: 0x0600EA0D RID: 59917 RVA: 0x003702E8 File Offset: 0x0036E4E8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA0E RID: 59918 RVA: 0x00071CA2 File Offset: 0x0006FEA2
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700485C RID: 18524
				// (get) Token: 0x0600EA0F RID: 59919 RVA: 0x00370328 File Offset: 0x0036E528
				// (set) Token: 0x0600EA10 RID: 59920 RVA: 0x00071CAB File Offset: 0x0006FEAB
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700485D RID: 18525
				// (get) Token: 0x0600EA11 RID: 59921 RVA: 0x00370350 File Offset: 0x0036E550
				// (set) Token: 0x0600EA12 RID: 59922 RVA: 0x00071CC6 File Offset: 0x0006FEC6
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700485E RID: 18526
				// (get) Token: 0x0600EA13 RID: 59923 RVA: 0x00370380 File Offset: 0x0036E580
				// (set) Token: 0x0600EA14 RID: 59924 RVA: 0x00071CE5 File Offset: 0x0006FEE5
				public unsafe Eye.__c__DisplayClass34_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye.__c__DisplayClass34_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700485F RID: 18527
				// (get) Token: 0x0600EA15 RID: 59925 RVA: 0x003703B0 File Offset: 0x0036E5B0
				// (set) Token: 0x0600EA16 RID: 59926 RVA: 0x00071D04 File Offset: 0x0006FF04
				public unsafe float _i_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass34_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x04009C97 RID: 40087
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009C98 RID: 40088
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009C99 RID: 40089
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009C9A RID: 40090
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x04009C9B RID: 40091
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009C9C RID: 40092
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C9D RID: 40093
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009C9E RID: 40094
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009C9F RID: 40095
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CA0 RID: 40096
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B3F RID: 2879
		[ObfuscatedName("ScheduleOne.AvatarFramework.Eye+<>c__DisplayClass38_0")]
		public sealed class __c__DisplayClass38_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DACC RID: 56012 RVA: 0x00344574 File Offset: 0x00342774
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye>.NativeClassPtr, "<>c__DisplayClass38_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr);
				Eye.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "<>4__this");
				Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_blinkDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "blinkDuration");
				Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "debug");
				Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_endState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "endState");
				Eye.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, 100680463);
				Eye.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, 100680464);
			}

			// Token: 0x0600DACD RID: 56013 RVA: 0x00344618 File Offset: 0x00342818
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DACE RID: 56014 RVA: 0x00344654 File Offset: 0x00342854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254660, XrefRangeEnd = 254665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DACF RID: 56015 RVA: 0x0006A20A File Offset: 0x0006840A
			public __c__DisplayClass38_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700437D RID: 17277
			// (get) Token: 0x0600DAD0 RID: 56016 RVA: 0x00344694 File Offset: 0x00342894
			// (set) Token: 0x0600DAD1 RID: 56017 RVA: 0x0006A213 File Offset: 0x00068413
			public unsafe Eye __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700437E RID: 17278
			// (get) Token: 0x0600DAD2 RID: 56018 RVA: 0x003446C4 File Offset: 0x003428C4
			// (set) Token: 0x0600DAD3 RID: 56019 RVA: 0x0006A232 File Offset: 0x00068432
			public unsafe float blinkDuration
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_blinkDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_blinkDuration)) = value;
				}
			}

			// Token: 0x1700437F RID: 17279
			// (get) Token: 0x0600DAD4 RID: 56020 RVA: 0x003446EC File Offset: 0x003428EC
			// (set) Token: 0x0600DAD5 RID: 56021 RVA: 0x0006A24D File Offset: 0x0006844D
			public unsafe bool debug
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_debug);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_debug)) = value;
				}
			}

			// Token: 0x17004380 RID: 17280
			// (get) Token: 0x0600DAD6 RID: 56022 RVA: 0x00344714 File Offset: 0x00342914
			// (set) Token: 0x0600DAD7 RID: 56023 RVA: 0x0006A268 File Offset: 0x00068468
			public unsafe Eye.EyeLidConfiguration endState
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_endState);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.NativeFieldInfoPtr_endState)) = value;
				}
			}

			// Token: 0x0400933F RID: 37695
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009340 RID: 37696
			private static readonly System.IntPtr NativeFieldInfoPtr_blinkDuration;

			// Token: 0x04009341 RID: 37697
			private static readonly System.IntPtr NativeFieldInfoPtr_debug;

			// Token: 0x04009342 RID: 37698
			private static readonly System.IntPtr NativeFieldInfoPtr_endState;

			// Token: 0x04009343 RID: 37699
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009344 RID: 37700
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CC2 RID: 3266
			[ObfuscatedName("ScheduleOne.AvatarFramework.Eye+<>c__DisplayClass38_0+<<Blink>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EA17 RID: 59927 RVA: 0x003703D8 File Offset: 0x0036E5D8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique()
				{
					Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0>.NativeClassPtr, "<<Blink>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<>1__state");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<>2__current");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<>4__this");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__start_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<start>5__2");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__end_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<end>5__3");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__holdTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<holdTime>5__4");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__duration_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<duration>5__5");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, "<i>5__6");
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680465);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680466);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680467);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680468);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680469);
					Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr, 100680470);
				}

				// Token: 0x0600EA18 RID: 59928 RVA: 0x0037051C File Offset: 0x0036E71C
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA19 RID: 59929 RVA: 0x00370564 File Offset: 0x0036E764
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA1A RID: 59930 RVA: 0x00370598 File Offset: 0x0036E798
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254644, XrefRangeEnd = 254655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x1700486A RID: 18538
				// (get) Token: 0x0600EA1B RID: 59931 RVA: 0x003705D4 File Offset: 0x0036E7D4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA1C RID: 59932 RVA: 0x00370614 File Offset: 0x0036E814
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254655, XrefRangeEnd = 254660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x1700486B RID: 18539
				// (get) Token: 0x0600EA1D RID: 59933 RVA: 0x00370648 File Offset: 0x0036E848
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA1E RID: 59934 RVA: 0x00071D1F File Offset: 0x0006FF1F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004862 RID: 18530
				// (get) Token: 0x0600EA1F RID: 59935 RVA: 0x00370688 File Offset: 0x0036E888
				// (set) Token: 0x0600EA20 RID: 59936 RVA: 0x00071D28 File Offset: 0x0006FF28
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004863 RID: 18531
				// (get) Token: 0x0600EA21 RID: 59937 RVA: 0x003706B0 File Offset: 0x0036E8B0
				// (set) Token: 0x0600EA22 RID: 59938 RVA: 0x00071D43 File Offset: 0x0006FF43
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004864 RID: 18532
				// (get) Token: 0x0600EA23 RID: 59939 RVA: 0x003706E0 File Offset: 0x0036E8E0
				// (set) Token: 0x0600EA24 RID: 59940 RVA: 0x00071D62 File Offset: 0x0006FF62
				public unsafe Eye.__c__DisplayClass38_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye.__c__DisplayClass38_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004865 RID: 18533
				// (get) Token: 0x0600EA25 RID: 59941 RVA: 0x00370710 File Offset: 0x0036E910
				// (set) Token: 0x0600EA26 RID: 59942 RVA: 0x00071D81 File Offset: 0x0006FF81
				public unsafe Eye.EyeLidConfiguration _start_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__start_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__start_5__2)) = value;
					}
				}

				// Token: 0x17004866 RID: 18534
				// (get) Token: 0x0600EA27 RID: 59943 RVA: 0x00370738 File Offset: 0x0036E938
				// (set) Token: 0x0600EA28 RID: 59944 RVA: 0x00071D9C File Offset: 0x0006FF9C
				public unsafe Eye.EyeLidConfiguration _end_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__end_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__end_5__3)) = value;
					}
				}

				// Token: 0x17004867 RID: 18535
				// (get) Token: 0x0600EA29 RID: 59945 RVA: 0x00370760 File Offset: 0x0036E960
				// (set) Token: 0x0600EA2A RID: 59946 RVA: 0x00071DB7 File Offset: 0x0006FFB7
				public unsafe float _holdTime_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__holdTime_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__holdTime_5__4)) = value;
					}
				}

				// Token: 0x17004868 RID: 18536
				// (get) Token: 0x0600EA2B RID: 59947 RVA: 0x00370788 File Offset: 0x0036E988
				// (set) Token: 0x0600EA2C RID: 59948 RVA: 0x00071DD2 File Offset: 0x0006FFD2
				public unsafe float _duration_5__5
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__duration_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__duration_5__5)) = value;
					}
				}

				// Token: 0x17004869 RID: 18537
				// (get) Token: 0x0600EA2D RID: 59949 RVA: 0x003707B0 File Offset: 0x0036E9B0
				// (set) Token: 0x0600EA2E RID: 59950 RVA: 0x00071DED File Offset: 0x0006FFED
				public unsafe float _i_5__6
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__i_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Eye.__c__DisplayClass38_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEySiEySiObSiObUnique.NativeFieldInfoPtr__i_5__6)) = value;
					}
				}

				// Token: 0x04009CA1 RID: 40097
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009CA2 RID: 40098
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009CA3 RID: 40099
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009CA4 RID: 40100
				private static readonly System.IntPtr NativeFieldInfoPtr__start_5__2;

				// Token: 0x04009CA5 RID: 40101
				private static readonly System.IntPtr NativeFieldInfoPtr__end_5__3;

				// Token: 0x04009CA6 RID: 40102
				private static readonly System.IntPtr NativeFieldInfoPtr__holdTime_5__4;

				// Token: 0x04009CA7 RID: 40103
				private static readonly System.IntPtr NativeFieldInfoPtr__duration_5__5;

				// Token: 0x04009CA8 RID: 40104
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__6;

				// Token: 0x04009CA9 RID: 40105
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009CAA RID: 40106
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CAB RID: 40107
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009CAC RID: 40108
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009CAD RID: 40109
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CAE RID: 40110
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
