using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Sound
{
	// Token: 0x02000517 RID: 1303
	public class VehicleSound : MonoBehaviour
	{
		// Token: 0x0600723F RID: 29247 RVA: 0x001F8B20 File Offset: 0x001F6D20
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleSound()
		{
			Il2CppClassPointerStore<VehicleSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Sound", "VehicleSound");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr);
			VehicleSound.NativeFieldInfoPtr_COLLISION_SOUND_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "COLLISION_SOUND_COOLDOWN");
			VehicleSound.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "VolumeMultiplier");
			VehicleSound.NativeFieldInfoPtr_EngineStartSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineStartSource");
			VehicleSound.NativeFieldInfoPtr_EngineIdleSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineIdleSource");
			VehicleSound.NativeFieldInfoPtr_EngineLoopSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineLoopSource");
			VehicleSound.NativeFieldInfoPtr_HandbrakeSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "HandbrakeSource");
			VehicleSound.NativeFieldInfoPtr_HonkSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "HonkSource");
			VehicleSound.NativeFieldInfoPtr_ImpactSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "ImpactSound");
			VehicleSound.NativeFieldInfoPtr_MinCollisionMomentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MinCollisionMomentum");
			VehicleSound.NativeFieldInfoPtr_MaxCollisionMomentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MaxCollisionMomentum");
			VehicleSound.NativeFieldInfoPtr_MinCollisionVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MinCollisionVolume");
			VehicleSound.NativeFieldInfoPtr_MaxCollisionVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MaxCollisionVolume");
			VehicleSound.NativeFieldInfoPtr_MinCollisionPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MinCollisionPitch");
			VehicleSound.NativeFieldInfoPtr_MaxCollisionPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "MaxCollisionPitch");
			VehicleSound.NativeFieldInfoPtr_EngineLoopPitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineLoopPitchCurve");
			VehicleSound.NativeFieldInfoPtr_EngineLoopPitchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineLoopPitchMultiplier");
			VehicleSound.NativeFieldInfoPtr_EngineLoopVolumeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "EngineLoopVolumeCurve");
			VehicleSound.NativeFieldInfoPtr__Vehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "<Vehicle>k__BackingField");
			VehicleSound.NativeFieldInfoPtr_currentIdleVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "currentIdleVolume");
			VehicleSound.NativeFieldInfoPtr_lastCollisionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "lastCollisionTime");
			VehicleSound.NativeFieldInfoPtr_lastCollisionMomentum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, "lastCollisionMomentum");
			VehicleSound.NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677769);
			VehicleSound.NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677770);
			VehicleSound.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677771);
			VehicleSound.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677772);
			VehicleSound.NativeMethodInfoPtr_UpdateIdle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677773);
			VehicleSound.NativeMethodInfoPtr_HandbrakeApplied_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677774);
			VehicleSound.NativeMethodInfoPtr_EngineStart_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677775);
			VehicleSound.NativeMethodInfoPtr_Honk_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677776);
			VehicleSound.NativeMethodInfoPtr_OnCollision_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677777);
			VehicleSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr, 100677778);
		}

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x06007240 RID: 29248 RVA: 0x001F8DBC File Offset: 0x001F6FBC
		// (set) Token: 0x06007241 RID: 29249 RVA: 0x001F8DFC File Offset: 0x001F6FFC
		public unsafe LandVehicle Vehicle
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 48192, RefRangeEnd = 48202, XrefRangeStart = 48192, XrefRangeEnd = 48202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 99021, RefRangeEnd = 99022, XrefRangeStart = 99021, XrefRangeEnd = 99022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007242 RID: 29250 RVA: 0x001F8E40 File Offset: 0x001F7040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225477, XrefRangeEnd = 225507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleSound.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007243 RID: 29251 RVA: 0x001F8E7C File Offset: 0x001F707C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225507, XrefRangeEnd = 225508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleSound.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007244 RID: 29252 RVA: 0x001F8EB8 File Offset: 0x001F70B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225520, RefRangeEnd = 225521, XrefRangeStart = 225508, XrefRangeEnd = 225520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIdle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_UpdateIdle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007245 RID: 29253 RVA: 0x001F8EEC File Offset: 0x001F70EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225521, XrefRangeEnd = 225522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandbrakeApplied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_HandbrakeApplied_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x001F8F20 File Offset: 0x001F7120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225522, XrefRangeEnd = 225523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EngineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_EngineStart_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007247 RID: 29255 RVA: 0x001F8F54 File Offset: 0x001F7154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225523, XrefRangeEnd = 225524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Honk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_Honk_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007248 RID: 29256 RVA: 0x001F8F88 File Offset: 0x001F7188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225524, XrefRangeEnd = 225542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollision(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr_OnCollision_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007249 RID: 29257 RVA: 0x001F8FCC File Offset: 0x001F71CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225542, XrefRangeEnd = 225543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSound>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600724A RID: 29258 RVA: 0x00035EFF File Offset: 0x000340FF
		public VehicleSound(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x0600724B RID: 29259 RVA: 0x001F9008 File Offset: 0x001F7208
		// (set) Token: 0x0600724C RID: 29260 RVA: 0x00035F08 File Offset: 0x00034108
		public unsafe static float COLLISION_SOUND_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleSound.NativeFieldInfoPtr_COLLISION_SOUND_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleSound.NativeFieldInfoPtr_COLLISION_SOUND_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x0600724D RID: 29261 RVA: 0x001F9024 File Offset: 0x001F7224
		// (set) Token: 0x0600724E RID: 29262 RVA: 0x00035F16 File Offset: 0x00034116
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x0600724F RID: 29263 RVA: 0x001F904C File Offset: 0x001F724C
		// (set) Token: 0x06007250 RID: 29264 RVA: 0x00035F31 File Offset: 0x00034131
		public unsafe AudioSourceController EngineStartSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineStartSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineStartSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x06007251 RID: 29265 RVA: 0x001F907C File Offset: 0x001F727C
		// (set) Token: 0x06007252 RID: 29266 RVA: 0x00035F50 File Offset: 0x00034150
		public unsafe AudioSourceController EngineIdleSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineIdleSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineIdleSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x06007253 RID: 29267 RVA: 0x001F90AC File Offset: 0x001F72AC
		// (set) Token: 0x06007254 RID: 29268 RVA: 0x00035F6F File Offset: 0x0003416F
		public unsafe AudioSourceController EngineLoopSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x06007255 RID: 29269 RVA: 0x001F90DC File Offset: 0x001F72DC
		// (set) Token: 0x06007256 RID: 29270 RVA: 0x00035F8E File Offset: 0x0003418E
		public unsafe AudioSourceController HandbrakeSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_HandbrakeSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_HandbrakeSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x06007257 RID: 29271 RVA: 0x001F910C File Offset: 0x001F730C
		// (set) Token: 0x06007258 RID: 29272 RVA: 0x00035FAD File Offset: 0x000341AD
		public unsafe AudioSourceController HonkSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_HonkSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_HonkSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x06007259 RID: 29273 RVA: 0x001F913C File Offset: 0x001F733C
		// (set) Token: 0x0600725A RID: 29274 RVA: 0x00035FCC File Offset: 0x000341CC
		public unsafe AudioSourceController ImpactSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_ImpactSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_ImpactSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x0600725B RID: 29275 RVA: 0x001F916C File Offset: 0x001F736C
		// (set) Token: 0x0600725C RID: 29276 RVA: 0x00035FEB File Offset: 0x000341EB
		public unsafe float MinCollisionMomentum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionMomentum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionMomentum)) = value;
			}
		}

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x0600725D RID: 29277 RVA: 0x001F9194 File Offset: 0x001F7394
		// (set) Token: 0x0600725E RID: 29278 RVA: 0x00036006 File Offset: 0x00034206
		public unsafe float MaxCollisionMomentum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionMomentum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionMomentum)) = value;
			}
		}

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x0600725F RID: 29279 RVA: 0x001F91BC File Offset: 0x001F73BC
		// (set) Token: 0x06007260 RID: 29280 RVA: 0x00036021 File Offset: 0x00034221
		public unsafe float MinCollisionVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionVolume)) = value;
			}
		}

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x06007261 RID: 29281 RVA: 0x001F91E4 File Offset: 0x001F73E4
		// (set) Token: 0x06007262 RID: 29282 RVA: 0x0003603C File Offset: 0x0003423C
		public unsafe float MaxCollisionVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionVolume)) = value;
			}
		}

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x06007263 RID: 29283 RVA: 0x001F920C File Offset: 0x001F740C
		// (set) Token: 0x06007264 RID: 29284 RVA: 0x00036057 File Offset: 0x00034257
		public unsafe float MinCollisionPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MinCollisionPitch)) = value;
			}
		}

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x06007265 RID: 29285 RVA: 0x001F9234 File Offset: 0x001F7434
		// (set) Token: 0x06007266 RID: 29286 RVA: 0x00036072 File Offset: 0x00034272
		public unsafe float MaxCollisionPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_MaxCollisionPitch)) = value;
			}
		}

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x06007267 RID: 29287 RVA: 0x001F925C File Offset: 0x001F745C
		// (set) Token: 0x06007268 RID: 29288 RVA: 0x0003608D File Offset: 0x0003428D
		public unsafe AnimationCurve EngineLoopPitchCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopPitchCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopPitchCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x06007269 RID: 29289 RVA: 0x001F928C File Offset: 0x001F748C
		// (set) Token: 0x0600726A RID: 29290 RVA: 0x000360AC File Offset: 0x000342AC
		public unsafe float EngineLoopPitchMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopPitchMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopPitchMultiplier)) = value;
			}
		}

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x0600726B RID: 29291 RVA: 0x001F92B4 File Offset: 0x001F74B4
		// (set) Token: 0x0600726C RID: 29292 RVA: 0x000360C7 File Offset: 0x000342C7
		public unsafe AnimationCurve EngineLoopVolumeCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopVolumeCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_EngineLoopVolumeCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x0600726D RID: 29293 RVA: 0x001F92E4 File Offset: 0x001F74E4
		// (set) Token: 0x0600726E RID: 29294 RVA: 0x000360E6 File Offset: 0x000342E6
		public unsafe LandVehicle _Vehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr__Vehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr__Vehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x0600726F RID: 29295 RVA: 0x001F9314 File Offset: 0x001F7514
		// (set) Token: 0x06007270 RID: 29296 RVA: 0x00036105 File Offset: 0x00034305
		public unsafe float currentIdleVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_currentIdleVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_currentIdleVolume)) = value;
			}
		}

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x06007271 RID: 29297 RVA: 0x001F933C File Offset: 0x001F753C
		// (set) Token: 0x06007272 RID: 29298 RVA: 0x00036120 File Offset: 0x00034320
		public unsafe float lastCollisionTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_lastCollisionTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_lastCollisionTime)) = value;
			}
		}

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x06007273 RID: 29299 RVA: 0x001F9364 File Offset: 0x001F7564
		// (set) Token: 0x06007274 RID: 29300 RVA: 0x0003613B File Offset: 0x0003433B
		public unsafe float lastCollisionMomentum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_lastCollisionMomentum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSound.NativeFieldInfoPtr_lastCollisionMomentum)) = value;
			}
		}

		// Token: 0x04004E11 RID: 19985
		private static readonly IntPtr NativeFieldInfoPtr_COLLISION_SOUND_COOLDOWN;

		// Token: 0x04004E12 RID: 19986
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x04004E13 RID: 19987
		private static readonly IntPtr NativeFieldInfoPtr_EngineStartSource;

		// Token: 0x04004E14 RID: 19988
		private static readonly IntPtr NativeFieldInfoPtr_EngineIdleSource;

		// Token: 0x04004E15 RID: 19989
		private static readonly IntPtr NativeFieldInfoPtr_EngineLoopSource;

		// Token: 0x04004E16 RID: 19990
		private static readonly IntPtr NativeFieldInfoPtr_HandbrakeSource;

		// Token: 0x04004E17 RID: 19991
		private static readonly IntPtr NativeFieldInfoPtr_HonkSource;

		// Token: 0x04004E18 RID: 19992
		private static readonly IntPtr NativeFieldInfoPtr_ImpactSound;

		// Token: 0x04004E19 RID: 19993
		private static readonly IntPtr NativeFieldInfoPtr_MinCollisionMomentum;

		// Token: 0x04004E1A RID: 19994
		private static readonly IntPtr NativeFieldInfoPtr_MaxCollisionMomentum;

		// Token: 0x04004E1B RID: 19995
		private static readonly IntPtr NativeFieldInfoPtr_MinCollisionVolume;

		// Token: 0x04004E1C RID: 19996
		private static readonly IntPtr NativeFieldInfoPtr_MaxCollisionVolume;

		// Token: 0x04004E1D RID: 19997
		private static readonly IntPtr NativeFieldInfoPtr_MinCollisionPitch;

		// Token: 0x04004E1E RID: 19998
		private static readonly IntPtr NativeFieldInfoPtr_MaxCollisionPitch;

		// Token: 0x04004E1F RID: 19999
		private static readonly IntPtr NativeFieldInfoPtr_EngineLoopPitchCurve;

		// Token: 0x04004E20 RID: 20000
		private static readonly IntPtr NativeFieldInfoPtr_EngineLoopPitchMultiplier;

		// Token: 0x04004E21 RID: 20001
		private static readonly IntPtr NativeFieldInfoPtr_EngineLoopVolumeCurve;

		// Token: 0x04004E22 RID: 20002
		private static readonly IntPtr NativeFieldInfoPtr__Vehicle_k__BackingField;

		// Token: 0x04004E23 RID: 20003
		private static readonly IntPtr NativeFieldInfoPtr_currentIdleVolume;

		// Token: 0x04004E24 RID: 20004
		private static readonly IntPtr NativeFieldInfoPtr_lastCollisionTime;

		// Token: 0x04004E25 RID: 20005
		private static readonly IntPtr NativeFieldInfoPtr_lastCollisionMomentum;

		// Token: 0x04004E26 RID: 20006
		private static readonly IntPtr NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0;

		// Token: 0x04004E27 RID: 20007
		private static readonly IntPtr NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0;

		// Token: 0x04004E28 RID: 20008
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004E29 RID: 20009
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004E2A RID: 20010
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIdle_Private_Void_0;

		// Token: 0x04004E2B RID: 20011
		private static readonly IntPtr NativeMethodInfoPtr_HandbrakeApplied_Protected_Void_0;

		// Token: 0x04004E2C RID: 20012
		private static readonly IntPtr NativeMethodInfoPtr_EngineStart_Protected_Void_0;

		// Token: 0x04004E2D RID: 20013
		private static readonly IntPtr NativeMethodInfoPtr_Honk_Public_Void_0;

		// Token: 0x04004E2E RID: 20014
		private static readonly IntPtr NativeMethodInfoPtr_OnCollision_Private_Void_Collision_0;

		// Token: 0x04004E2F RID: 20015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
