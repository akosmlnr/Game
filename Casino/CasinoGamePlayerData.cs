using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004C6 RID: 1222
	public class CasinoGamePlayerData : Il2CppSystem.Object
	{
		// Token: 0x0600694C RID: 26956 RVA: 0x001DAFC0 File Offset: 0x001D91C0
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGamePlayerData()
		{
			Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CasinoGamePlayerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr);
			CasinoGamePlayerData.NativeFieldInfoPtr__Parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, "<Parent>k__BackingField");
			CasinoGamePlayerData.NativeFieldInfoPtr__Player_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, "<Player>k__BackingField");
			CasinoGamePlayerData.NativeFieldInfoPtr_bools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, "bools");
			CasinoGamePlayerData.NativeFieldInfoPtr_floats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, "floats");
			CasinoGamePlayerData.NativeMethodInfoPtr_get_Parent_Public_get_CasinoGamePlayers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676735);
			CasinoGamePlayerData.NativeMethodInfoPtr_set_Parent_Private_set_Void_CasinoGamePlayers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676736);
			CasinoGamePlayerData.NativeMethodInfoPtr_get_Player_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676737);
			CasinoGamePlayerData.NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676738);
			CasinoGamePlayerData.NativeMethodInfoPtr__ctor_Public_Void_CasinoGamePlayers_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676739);
			CasinoGamePlayerData.NativeMethodInfoPtr_GetData_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676740);
			CasinoGamePlayerData.NativeMethodInfoPtr_SetData_Public_Void_String_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676741);
		}

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x0600694D RID: 26957 RVA: 0x001DB0CC File Offset: 0x001D92CC
		// (set) Token: 0x0600694E RID: 26958 RVA: 0x001DB10C File Offset: 0x001D930C
		public unsafe CasinoGamePlayers Parent
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 18697, RefRangeEnd = 18709, XrefRangeStart = 18697, XrefRangeEnd = 18709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr_get_Parent_Public_get_CasinoGamePlayers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31460, RefRangeEnd = 31462, XrefRangeStart = 31460, XrefRangeEnd = 31462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr_set_Parent_Private_set_Void_CasinoGamePlayers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x0600694F RID: 26959 RVA: 0x001DB150 File Offset: 0x001D9350
		// (set) Token: 0x06006950 RID: 26960 RVA: 0x001DB190 File Offset: 0x001D9390
		public unsafe Player Player
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr_get_Player_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006951 RID: 26961 RVA: 0x001DB1D4 File Offset: 0x001D93D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 213468, RefRangeEnd = 213473, XrefRangeStart = 213441, XrefRangeEnd = 213468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerData(CasinoGamePlayers parent, Player player) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr__ctor_Public_Void_CasinoGamePlayers_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x001DB234 File Offset: 0x001D9434
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 213505, RefRangeEnd = 213516, XrefRangeStart = 213473, XrefRangeEnd = 213505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetData<T>(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			System.IntPtr returnedException;
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.MethodInfoStoreGeneric_GetData_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x001DB280 File Offset: 0x001D9480
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 213563, RefRangeEnd = 213569, XrefRangeStart = 213516, XrefRangeEnd = 213563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData<T>(string key, T value, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.MethodInfoStoreGeneric_SetData_Public_Void_String_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006954 RID: 26964 RVA: 0x00031826 File Offset: 0x0002FA26
		public CasinoGamePlayerData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x06006955 RID: 26965 RVA: 0x001DB318 File Offset: 0x001D9518
		// (set) Token: 0x06006956 RID: 26966 RVA: 0x0003182F File Offset: 0x0002FA2F
		public unsafe CasinoGamePlayers _Parent_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr__Parent_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr__Parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F79 RID: 8057
		// (get) Token: 0x06006957 RID: 26967 RVA: 0x001DB348 File Offset: 0x001D9548
		// (set) Token: 0x06006958 RID: 26968 RVA: 0x0003184E File Offset: 0x0002FA4E
		public unsafe Player _Player_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr__Player_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr__Player_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F7A RID: 8058
		// (get) Token: 0x06006959 RID: 26969 RVA: 0x001DB378 File Offset: 0x001D9578
		// (set) Token: 0x0600695A RID: 26970 RVA: 0x0003186D File Offset: 0x0002FA6D
		public unsafe Dictionary<string, bool> bools
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr_bools);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr_bools), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x0600695B RID: 26971 RVA: 0x001DB3A8 File Offset: 0x001D95A8
		// (set) Token: 0x0600695C RID: 26972 RVA: 0x0003188C File Offset: 0x0002FA8C
		public unsafe Dictionary<string, float> floats
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr_floats);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr_floats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004815 RID: 18453
		private static readonly System.IntPtr NativeFieldInfoPtr__Parent_k__BackingField;

		// Token: 0x04004816 RID: 18454
		private static readonly System.IntPtr NativeFieldInfoPtr__Player_k__BackingField;

		// Token: 0x04004817 RID: 18455
		private static readonly System.IntPtr NativeFieldInfoPtr_bools;

		// Token: 0x04004818 RID: 18456
		private static readonly System.IntPtr NativeFieldInfoPtr_floats;

		// Token: 0x04004819 RID: 18457
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Parent_Public_get_CasinoGamePlayers_0;

		// Token: 0x0400481A RID: 18458
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Parent_Private_set_Void_CasinoGamePlayers_0;

		// Token: 0x0400481B RID: 18459
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Player_Public_get_Player_0;

		// Token: 0x0400481C RID: 18460
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0;

		// Token: 0x0400481D RID: 18461
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CasinoGamePlayers_Player_0;

		// Token: 0x0400481E RID: 18462
		private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_T_String_0;

		// Token: 0x0400481F RID: 18463
		private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Public_Void_String_T_Boolean_0;

		// Token: 0x02000A8C RID: 2700
		private sealed class MethodInfoStoreGeneric_GetData_Public_T_String_0<T>
		{
			// Token: 0x04008FB4 RID: 36788
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CasinoGamePlayerData.NativeMethodInfoPtr_GetData_Public_T_String_0, Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A8D RID: 2701
		private sealed class MethodInfoStoreGeneric_SetData_Public_Void_String_T_Boolean_0<T>
		{
			// Token: 0x04008FB5 RID: 36789
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CasinoGamePlayerData.NativeMethodInfoPtr_SetData_Public_Void_String_T_Boolean_0, Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
