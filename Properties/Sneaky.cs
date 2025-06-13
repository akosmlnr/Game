using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vision;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001F5 RID: 501
	public class Sneaky : Property
	{
		// Token: 0x0600288F RID: 10383 RVA: 0x000F38FC File Offset: 0x000F1AFC
		// Note: this type is marked as 'beforefieldinit'.
		static Sneaky()
		{
			Il2CppClassPointerStore<Sneaky>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "Sneaky");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sneaky>.NativeClassPtr);
			Sneaky.NativeFieldInfoPtr_SPEED_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sneaky>.NativeClassPtr, "SPEED_MULTIPLIER");
			Sneaky.NativeFieldInfoPtr_FOOTSTEP_VOL_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sneaky>.NativeClassPtr, "FOOTSTEP_VOL_MULTIPLIER");
			Sneaky.NativeFieldInfoPtr_visibilityAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sneaky>.NativeClassPtr, "visibilityAttribute");
			Sneaky.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sneaky>.NativeClassPtr, 100667914);
			Sneaky.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sneaky>.NativeClassPtr, 100667915);
			Sneaky.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sneaky>.NativeClassPtr, 100667916);
			Sneaky.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sneaky>.NativeClassPtr, 100667917);
			Sneaky.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sneaky>.NativeClassPtr, 100667918);
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x000F39CC File Offset: 0x000F1BCC
		[CallerCount(0)]
		public unsafe override void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sneaky.NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x000F3A1C File Offset: 0x000F1C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121653, XrefRangeEnd = 121671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sneaky.NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x000F3A6C File Offset: 0x000F1C6C
		[CallerCount(0)]
		public unsafe override void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sneaky.NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x000F3ABC File Offset: 0x000F1CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121671, XrefRangeEnd = 121684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sneaky.NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x000F3B0C File Offset: 0x000F1D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sneaky() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sneaky>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sneaky.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x00015FD4 File Offset: 0x000141D4
		public Sneaky(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x000F3B48 File Offset: 0x000F1D48
		// (set) Token: 0x06002897 RID: 10391 RVA: 0x00015FDD File Offset: 0x000141DD
		public unsafe static float SPEED_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Sneaky.NativeFieldInfoPtr_SPEED_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Sneaky.NativeFieldInfoPtr_SPEED_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x000F3B64 File Offset: 0x000F1D64
		// (set) Token: 0x06002899 RID: 10393 RVA: 0x00015FEB File Offset: 0x000141EB
		public unsafe static float FOOTSTEP_VOL_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Sneaky.NativeFieldInfoPtr_FOOTSTEP_VOL_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Sneaky.NativeFieldInfoPtr_FOOTSTEP_VOL_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x000F3B80 File Offset: 0x000F1D80
		// (set) Token: 0x0600289B RID: 10395 RVA: 0x00015FF9 File Offset: 0x000141F9
		public unsafe VisibilityAttribute visibilityAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sneaky.NativeFieldInfoPtr_visibilityAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sneaky.NativeFieldInfoPtr_visibilityAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeFieldInfoPtr_SPEED_MULTIPLIER;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeFieldInfoPtr_FOOTSTEP_VOL_MULTIPLIER;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeFieldInfoPtr_visibilityAttribute;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Virtual_Void_NPC_0;

		// Token: 0x04001AF8 RID: 6904
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Virtual_Void_Player_0;

		// Token: 0x04001AF9 RID: 6905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
